using QueryBuilder.Main;
using System;
using System.Windows.Forms;
using System.Drawing;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                var row = dgvAccounts.SelectedRows[0];
                string id = row.Cells["Account ID"].Value.ToString();
                string accName = row.Cells["Account Name"].Value.ToString();
                string pin = row.Cells["PIN"].Value.ToString();
                string balance = row.Cells["Total Balance"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                Form2 updateForm = new Form2(id, accName, pin, balance, status);
                updateForm.ShowDialog();
                LoadAccounts();
                ComputeAggregates();
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
