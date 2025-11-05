using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using QueryBuilder.config;

namespace QueryBuilder.core
{
    public class QueryBuilder
    {
        private StringBuilder _select = new StringBuilder();
        private string _from;
        private List<string> _wheres = new List<string>();
        private List<MySqlParameter> _parameters = new List<MySqlParameter>();
        private string _groupBy;
        private string _orderBy;
        private bool _isInsert, _isUpdate;
        private StringBuilder _insertCols = new StringBuilder();
        private StringBuilder _insertVals = new StringBuilder();
        private StringBuilder _updateSet = new StringBuilder();

        public QueryBuilder Select(string cols = "*") { _select.Clear(); _select.Append(cols); return this; }
        public QueryBuilder From(string table) { _from = table; return this; }
        public QueryBuilder Where(string column, object value, string op = "=")
        {
            string paramName = $"@p{_parameters.Count}";
            _wheres.Add($"`{column}` {op} {paramName}");
            _parameters.Add(new MySqlParameter(paramName, value ?? DBNull.Value));
            return this;
        }
        public QueryBuilder OrderBy(string cols) { _orderBy = cols; return this; }

        public QueryBuilder InsertInto(string table) { _isInsert = true; _from = table; return this; }
        public QueryBuilder Value(string col, object val)
        {
            if (_insertCols.Length > 0) { _insertCols.Append(","); _insertVals.Append(","); }
            string paramName = $"@p{_parameters.Count}";
            _insertCols.Append($"`{col}`");
            _insertVals.Append(paramName);
            _parameters.Add(new MySqlParameter(paramName, val ?? DBNull.Value));
            return this;
        }

        public QueryBuilder Update(string table) { _isUpdate = true; _from = table; return this; }
        public QueryBuilder Set(string col, object val)
        {
            if (_updateSet.Length > 0) _updateSet.Append(",");
            string paramName = $"@p{_parameters.Count}";
            _updateSet.Append($"`{col}`={paramName}");
            _parameters.Add(new MySqlParameter(paramName, val ?? DBNull.Value));
            return this;
        }

        private string BuildSelectSql()
        {
            var sb = new StringBuilder();
            sb.Append("SELECT ").Append(_select).Append(" FROM ").Append(_from);
            if (_wheres.Count > 0) sb.Append(" WHERE ").Append(string.Join(" AND ", _wheres));
            if (!string.IsNullOrEmpty(_orderBy)) sb.Append(" ORDER BY ").Append(_orderBy);
            return sb.ToString();
        }

        private string BuildInsertSql() => $"INSERT INTO {_from} ({_insertCols}) VALUES ({_insertVals})";
        private string BuildUpdateSql()
        {
            var sb = new StringBuilder();
            sb.Append($"UPDATE {_from} SET {_updateSet}");
            if (_wheres.Count > 0) sb.Append(" WHERE ").Append(string.Join(" AND ", _wheres));
            return sb.ToString();
        }

        public DataTable Get()
        {
            string sql = _isInsert ? BuildInsertSql() : _isUpdate ? BuildUpdateSql() : BuildSelectSql();
            if (_isInsert || _isUpdate)
            {
                ExecuteNonQuery(sql);
                return new DataTable();
            }
            return ExecuteQuery(sql);
        }

        private DataTable ExecuteQuery(string sql)
        {
            using (var conn = Connection.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (_parameters.Count > 0) cmd.Parameters.AddRange(_parameters.ToArray());
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                conn.Open(); da.Fill(dt); return dt;
            }
        }

        private void ExecuteNonQuery(string sql)
        {
            using (var conn = Connection.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (_parameters.Count > 0) cmd.Parameters.AddRange(_parameters.ToArray());
                conn.Open(); cmd.ExecuteNonQuery();
            }
        }

        private object Scalar(string expr)
        {
            var sb = new StringBuilder($"SELECT {expr} FROM {_from}");
            using (var conn = Connection.GetConnection())
            using (var cmd = new MySqlCommand(sb.ToString(), conn))
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public object CountAll() => Scalar("COUNT(*)");
        public object Max(string col) => Scalar($"MAX(`{col}`)");
        public object Min(string col) => Scalar($"MIN(`{col}`)");
        public object Average(string col) => Scalar($"AVG(`{col}`)");
        public object Sum(string col) => Scalar($"SUM(`{col}`)");
    }
}
