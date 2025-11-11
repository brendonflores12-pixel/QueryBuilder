namespace QueryBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            dgvAccounts = new DataGridView();
            pnlCount = new Panel();
            valCount = new Label();
            lblCount = new Label();
            pnlMax = new Panel();
            valMax = new Label();
            lblMax = new Label();
            pnlMin = new Panel();
            valMin = new Label();
            lblMin = new Label();
            pnlAvg = new Panel();
            valAvg = new Label();
            lblAvg = new Label();
            pnlSum = new Panel();
            valSum = new Label();
            lblSum = new Label();
            btnAdd = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            pnlCount.SuspendLayout();
            pnlMax.SuspendLayout();
            pnlMin.SuspendLayout();
            pnlAvg.SuspendLayout();
            pnlSum.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1199, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "❌";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AllowUserToResizeColumns = false;
            dgvAccounts.AllowUserToResizeRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(95, 307);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(1047, 359);
            dgvAccounts.TabIndex = 2;
            // 
            // pnlCount
            // 
            pnlCount.BackColor = Color.LightSteelBlue;
            pnlCount.Controls.Add(valCount);
            pnlCount.Controls.Add(lblCount);
            pnlCount.Location = new Point(97, 182);
            pnlCount.Name = "pnlCount";
            pnlCount.Size = new Size(200, 102);
            pnlCount.TabIndex = 3;
            // 
            // valCount
            // 
            valCount.AutoSize = true;
            valCount.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            valCount.Location = new Point(77, 39);
            valCount.Name = "valCount";
            valCount.Size = new Size(40, 46);
            valCount.TabIndex = 1;
            valCount.Text = "0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(45, 5);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(105, 25);
            lblCount.TabIndex = 0;
            lblCount.Text = "Total Users";
            // 
            // pnlMax
            // 
            pnlMax.BackColor = Color.LightGreen;
            pnlMax.Controls.Add(valMax);
            pnlMax.Controls.Add(lblMax);
            pnlMax.Location = new Point(516, 182);
            pnlMax.Name = "pnlMax";
            pnlMax.Size = new Size(207, 102);
            pnlMax.TabIndex = 4;
            // 
            // valMax
            // 
            valMax.AutoSize = true;
            valMax.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            valMax.Location = new Point(3, 38);
            valMax.Name = "valMax";
            valMax.Size = new Size(40, 46);
            valMax.TabIndex = 1;
            valMax.Text = "0";
            valMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax.Location = new Point(19, 5);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(169, 25);
            lblMax.TabIndex = 0;
            lblMax.Text = "Maximum Balance";
            // 
            // pnlMin
            // 
            pnlMin.BackColor = Color.LightCoral;
            pnlMin.Controls.Add(valMin);
            pnlMin.Controls.Add(lblMin);
            pnlMin.Location = new Point(729, 182);
            pnlMin.Name = "pnlMin";
            pnlMin.Size = new Size(207, 102);
            pnlMin.TabIndex = 5;
            // 
            // valMin
            // 
            valMin.AutoSize = true;
            valMin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            valMin.Location = new Point(3, 39);
            valMin.Name = "valMin";
            valMin.Size = new Size(40, 46);
            valMin.TabIndex = 1;
            valMin.Text = "0";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMin.Location = new Point(22, 5);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(165, 25);
            lblMin.TabIndex = 0;
            lblMin.Text = "Minimum Balance";
            // 
            // pnlAvg
            // 
            pnlAvg.BackColor = Color.Khaki;
            pnlAvg.Controls.Add(valAvg);
            pnlAvg.Controls.Add(lblAvg);
            pnlAvg.Location = new Point(942, 182);
            pnlAvg.Name = "pnlAvg";
            pnlAvg.Size = new Size(200, 102);
            pnlAvg.TabIndex = 4;
            // 
            // valAvg
            // 
            valAvg.AutoSize = true;
            valAvg.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            valAvg.Location = new Point(3, 39);
            valAvg.Name = "valAvg";
            valAvg.Size = new Size(40, 46);
            valAvg.TabIndex = 1;
            valAvg.Text = "0";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvg.Location = new Point(20, 5);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(155, 25);
            lblAvg.TabIndex = 0;
            lblAvg.Text = "Balance Average";
            // 
            // pnlSum
            // 
            pnlSum.BackColor = Color.LightSkyBlue;
            pnlSum.Controls.Add(valSum);
            pnlSum.Controls.Add(lblSum);
            pnlSum.Location = new Point(303, 182);
            pnlSum.Name = "pnlSum";
            pnlSum.Size = new Size(207, 102);
            pnlSum.TabIndex = 4;
            // 
            // valSum
            // 
            valSum.AutoSize = true;
            valSum.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            valSum.Location = new Point(3, 39);
            valSum.Name = "valSum";
            valSum.Size = new Size(40, 46);
            valSum.TabIndex = 1;
            valSum.Text = "0";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(42, 5);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(126, 25);
            lblSum.TabIndex = 0;
            lblSum.Text = "Total Balance";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(97, 684);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(1047, 76);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "➕ Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 59);
            label1.Name = "label1";
            label1.Size = new Size(736, 56);
            label1.TabIndex = 7;
            label1.Text = "Account Management Dashboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1235, 782);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(pnlSum);
            Controls.Add(pnlAvg);
            Controls.Add(pnlMin);
            Controls.Add(pnlMax);
            Controls.Add(pnlCount);
            Controls.Add(dgvAccounts);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            pnlCount.ResumeLayout(false);
            pnlCount.PerformLayout();
            pnlMax.ResumeLayout(false);
            pnlMax.PerformLayout();
            pnlMin.ResumeLayout(false);
            pnlMin.PerformLayout();
            pnlAvg.ResumeLayout(false);
            pnlAvg.PerformLayout();
            pnlSum.ResumeLayout(false);
            pnlSum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private DataGridView dgvAccounts;
        private Panel pnlCount;
        private Label valCount;
        private Label lblCount;
        private Panel pnlMax;
        private Label valMax;
        private Label lblMax;
        private Panel pnlMin;
        private Label valMin;
        private Label lblMin;
        private Panel pnlAvg;
        private Label valAvg;
        private Label lblAvg;
        private Panel pnlSum;
        private Label valSum;
        private Label lblSum;
        private Button btnAdd;
        private Label label1;
    }
}
