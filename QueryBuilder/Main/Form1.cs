using Org.BouncyCastle.Asn1.Cmp;
using QueryBuilder.Main;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAccounts();
            ComputeAggregates();
        }

        private void LoadAccounts()
        {
            var dt = new QueryBuilder.core.QueryBuilder()
                .Select("*")
                .From("accounts")
                .OrderBy("`Account ID` ASC")
                .Get();

            dgvAccounts.DataSource = dt;

            AddActionButtons();

            dgvAccounts.ClearSelection();
        }

        private void ComputeAggregates()
        {
            var qb = new QueryBuilder.core.QueryBuilder().From("accounts");
            object count = qb.CountAll();
            object max = qb.Max("Total Balance");
            object min = qb.Min("Total Balance");
            object avg = qb.Average("Total Balance");
            object sum = qb.Sum("Total Balance");

            valCount.Text = (count == DBNull.Value ? "0" : count.ToString());
            valMax.Text = (max == DBNull.Value ? "0" : max.ToString());
            valMin.Text = (min == DBNull.Value ? "0" : min.ToString());
            valAvg.Text = (avg == DBNull.Value ? "0" : Math.Round(Convert.ToDouble(avg), 2).ToString());
            valSum.Text = (sum == DBNull.Value ? "0" : Math.Round(Convert.ToDouble(sum), 2).ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            LoadAccounts();
            ComputeAggregates();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddActionButtons()
        {
            if (dgvAccounts.Columns.Contains("Edit")) dgvAccounts.Columns.Remove("Edit");
            if (dgvAccounts.Columns.Contains("Delete")) dgvAccounts.Columns.Remove("Delete");

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Edit";
            editColumn.Name = "Edit";
            editColumn.Text = "✏️";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Width = 50;
            dgvAccounts.Columns.Add(editColumn);

            DataGridViewButtonColumn delColumn = new DataGridViewButtonColumn();
            delColumn.HeaderText = "Delete";
            delColumn.Name = "Delete";
            delColumn.Text = "🗑️";
            delColumn.UseColumnTextForButtonValue = true;
            delColumn.Width = 50;
            dgvAccounts.Columns.Add(delColumn);
            dgvAccounts.CellContentClick -= DgvAccounts_CellContentClick;
            dgvAccounts.CellContentClick += DgvAccounts_CellContentClick;
        }
        private void DgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvAccounts.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                string id = dgvAccounts.Rows[e.RowIndex].Cells["Account ID"].Value.ToString();
                string accName = dgvAccounts.Rows[e.RowIndex].Cells["Account Name"].Value.ToString();
                string pin = dgvAccounts.Rows[e.RowIndex].Cells["PIN"].Value.ToString();
                string balance = dgvAccounts.Rows[e.RowIndex].Cells["Total Balance"].Value.ToString();
                string status = dgvAccounts.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                Form2 editForm = new Form2(id, accName, pin, balance, status);
                editForm.ShowDialog();
                LoadAccounts();
                ComputeAggregates();
            }
            else if (columnName == "Delete")
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this row?",
                    "Remove Row",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    dgvAccounts.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Deleted Successfuly.");
                }
            }
        }
    }
}
