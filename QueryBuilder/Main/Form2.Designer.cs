namespace QueryBuilder.Main
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAccNo = new Label();
            lblPIN = new Label();
            lblBalance = new Label();
            lblStatus = new Label();
            txtAccNo = new TextBox();
            txtPIN = new TextBox();
            txtBalance = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            cmbStatus = new ComboBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblAccNo
            // 
            lblAccNo.AutoSize = true;
            lblAccNo.BackColor = Color.Transparent;
            lblAccNo.Font = new Font("Segoe UI", 18F);
            lblAccNo.Location = new Point(167, 67);
            lblAccNo.Name = "lblAccNo";
            lblAccNo.Size = new Size(214, 41);
            lblAccNo.TabIndex = 0;
            lblAccNo.Text = "Account Name";
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.BackColor = Color.Transparent;
            lblPIN.Font = new Font("Segoe UI", 18F);
            lblPIN.Location = new Point(240, 179);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(65, 41);
            lblPIN.TabIndex = 1;
            lblPIN.Text = "PIN";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Segoe UI", 18F);
            lblBalance.Location = new Point(179, 297);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(190, 41);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Total Balance";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 18F);
            lblStatus.Location = new Point(224, 406);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(98, 41);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // txtAccNo
            // 
            txtAccNo.Font = new Font("Segoe UI", 16.2F);
            txtAccNo.Location = new Point(56, 121);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.Size = new Size(430, 43);
            txtAccNo.TabIndex = 4;
            // 
            // txtPIN
            // 
            txtPIN.Font = new Font("Segoe UI", 16.2F);
            txtPIN.Location = new Point(56, 232);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(430, 43);
            txtPIN.TabIndex = 5;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 16.2F);
            txtBalance.Location = new Point(56, 351);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(430, 43);
            txtBalance.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(56, 563);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 57);
            btnAdd.TabIndex = 9;
            btnAdd.Text = " Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(56, 563);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 57);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive", "Suspended" });
            cmbStatus.Location = new Point(56, 459);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(430, 45);
            cmbStatus.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(324, 563);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 59);
            btnExit.TabIndex = 11;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.LightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 667);
            Controls.Add(btnExit);
            Controls.Add(cmbStatus);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(txtBalance);
            Controls.Add(txtPIN);
            Controls.Add(txtAccNo);
            Controls.Add(lblStatus);
            Controls.Add(lblBalance);
            Controls.Add(lblPIN);
            Controls.Add(lblAccNo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccNo;
        private Label lblPIN;
        private Label lblBalance;
        private Label lblStatus;
        private TextBox txtAccNo;
        private TextBox txtPIN;
        private TextBox txtBalance;
        private Button btnAdd;
        private Button btnUpdate;
        private ComboBox cmbStatus;
        private Button btnExit;
    }
}