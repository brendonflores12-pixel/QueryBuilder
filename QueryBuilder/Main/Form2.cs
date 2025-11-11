using System;
using System.Windows.Forms;

namespace QueryBuilder.Main
{
    public partial class Form2 : Form
    {
        private string recordId = "";
        private bool isEditMode = false;

        public Form2()
        {
            InitializeComponent();
            LoadStatusOptions();
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }

        public Form2(string id, string accName, string pin, string balance, string status)
        {
            InitializeComponent();
            LoadStatusOptions();
            isEditMode = true;
            recordId = id;
            txtAccNo.Text = accName;
            txtPIN.Text = pin;
            txtBalance.Text = balance;
            cmbStatus.Text = status;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
        }

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.Items.Add("Suspended");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new QueryBuilder.core.QueryBuilder()
               .InsertInto("accounts")
               .Value("Account Name", txtAccNo.Text)
               .Value("PIN", txtPIN.Text)
               .Value("Total Balance", Convert.ToDecimal(txtBalance.Text))
               .Value("Status", cmbStatus.Text)
               .Get();

            MessageBox.Show("Account added successfully!",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new QueryBuilder.core.QueryBuilder()
                .Update("accounts")
                .Set("Account Name", txtAccNo.Text)
                .Set("PIN", txtPIN.Text)
                .Set("Total Balance", Convert.ToDecimal(txtBalance.Text))
                .Set("Status", cmbStatus.Text)
                .Where("Account ID", recordId)
                .Get();

            MessageBox.Show("Account updated successfully!",
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
