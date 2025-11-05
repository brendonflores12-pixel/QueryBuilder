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
            btnUpdate = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            pnlCount.SuspendLayout();
            pnlMax.SuspendLayout();
            pnlMin.SuspendLayout();
            pnlAvg.SuspendLayout();
            pnlSum.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(896, 569);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 76);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "✏️Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1080, 2);
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
            dgvAccounts.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgvAccounts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(114, 391);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(732, 359);
            dgvAccounts.TabIndex = 2;
            // 
            // pnlCount
            // 
            pnlCount.BackColor = Color.LightSteelBlue;
            pnlCount.Controls.Add(valCount);
            pnlCount.Controls.Add(lblCount);
            pnlCount.Location = new Point(111, 67);
            pnlCount.Name = "pnlCount";
            pnlCount.Size = new Size(249, 119);
            pnlCount.TabIndex = 3;
            // 
            // valCount
            // 
            valCount.AutoSize = true;
            valCount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valCount.Location = new Point(3, 42);
            valCount.Name = "valCount";
            valCount.Size = new Size(50, 60);
            valCount.TabIndex = 1;
            valCount.Text = "0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(55, 9);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(137, 20);
            lblCount.TabIndex = 0;
            lblCount.Text = "ACCOUNT COUNT";
            // 
            // pnlMax
            // 
            pnlMax.BackColor = Color.LightGreen;
            pnlMax.Controls.Add(valMax);
            pnlMax.Controls.Add(lblMax);
            pnlMax.Location = new Point(429, 67);
            pnlMax.Name = "pnlMax";
            pnlMax.Size = new Size(256, 119);
            pnlMax.TabIndex = 4;
            // 
            // valMax
            // 
            valMax.AutoSize = true;
            valMax.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valMax.Location = new Point(3, 42);
            valMax.Name = "valMax";
            valMax.Size = new Size(50, 60);
            valMax.TabIndex = 1;
            valMax.Text = "0";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax.Location = new Point(111, 9);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(44, 20);
            lblMax.TabIndex = 0;
            lblMax.Text = "MAX";
            // 
            // pnlMin
            // 
            pnlMin.BackColor = Color.LightCoral;
            pnlMin.Controls.Add(valMin);
            pnlMin.Controls.Add(lblMin);
            pnlMin.Location = new Point(761, 67);
            pnlMin.Name = "pnlMin";
            pnlMin.Size = new Size(240, 119);
            pnlMin.TabIndex = 5;
            // 
            // valMin
            // 
            valMin.AutoSize = true;
            valMin.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valMin.Location = new Point(3, 42);
            valMin.Name = "valMin";
            valMin.Size = new Size(50, 60);
            valMin.TabIndex = 1;
            valMin.Text = "0";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMin.Location = new Point(108, 9);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(40, 20);
            lblMin.TabIndex = 0;
            lblMin.Text = "MIN";
            // 
            // pnlAvg
            // 
            pnlAvg.BackColor = Color.Khaki;
            pnlAvg.Controls.Add(valAvg);
            pnlAvg.Controls.Add(lblAvg);
            pnlAvg.Location = new Point(195, 225);
            pnlAvg.Name = "pnlAvg";
            pnlAvg.Size = new Size(263, 120);
            pnlAvg.TabIndex = 4;
            // 
            // valAvg
            // 
            valAvg.AutoSize = true;
            valAvg.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valAvg.Location = new Point(3, 43);
            valAvg.Name = "valAvg";
            valAvg.Size = new Size(50, 60);
            valAvg.TabIndex = 1;
            valAvg.Text = "0";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvg.Location = new Point(88, 15);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(77, 20);
            lblAvg.TabIndex = 0;
            lblAvg.Text = "AVERAGE";
            // 
            // pnlSum
            // 
            pnlSum.BackColor = Color.LightSkyBlue;
            pnlSum.Controls.Add(valSum);
            pnlSum.Controls.Add(lblSum);
            pnlSum.Location = new Point(654, 226);
            pnlSum.Name = "pnlSum";
            pnlSum.Size = new Size(261, 119);
            pnlSum.TabIndex = 4;
            // 
            // valSum
            // 
            valSum.AutoSize = true;
            valSum.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valSum.Location = new Point(3, 42);
            valSum.Name = "valSum";
            valSum.Size = new Size(50, 60);
            valSum.TabIndex = 1;
            valSum.Text = "0";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(110, 14);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(42, 20);
            lblSum.TabIndex = 0;
            lblSum.Text = "SUM";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(896, 431);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 76);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "➕ Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1116, 794);
            Controls.Add(btnAdd);
            Controls.Add(pnlSum);
            Controls.Add(pnlAvg);
            Controls.Add(pnlMin);
            Controls.Add(pnlMax);
            Controls.Add(pnlCount);
            Controls.Add(dgvAccounts);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
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
        }

        #endregion

        private Button btnUpdate;
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
    }
}
