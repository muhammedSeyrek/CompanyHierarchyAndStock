namespace Company
{
    partial class AddEmployee
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
            lblCollar = new Label();
            lblComm = new Label();
            lblSalary = new Label();
            lblBirthday = new Label();
            lblJob = new Label();
            lblPersonName = new Label();
            cmbCollar = new ComboBox();
            txtComm = new TextBox();
            txtSalary = new TextBox();
            txtBirthday = new TextBox();
            txtJob = new TextBox();
            txtName = new TextBox();
            btnAdd = new Button();
            txtMessages = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblCollar
            // 
            lblCollar.AutoSize = true;
            lblCollar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCollar.Location = new Point(32, 279);
            lblCollar.Name = "lblCollar";
            lblCollar.Size = new Size(63, 28);
            lblCollar.TabIndex = 39;
            lblCollar.Text = "Collar";
            // 
            // lblComm
            // 
            lblComm.AutoSize = true;
            lblComm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComm.Location = new Point(32, 230);
            lblComm.Name = "lblComm";
            lblComm.Size = new Size(70, 28);
            lblComm.TabIndex = 37;
            lblComm.Text = "Comm";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(32, 181);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(65, 28);
            lblSalary.TabIndex = 36;
            lblSalary.Text = "Salary";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(32, 132);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(85, 28);
            lblBirthday.TabIndex = 35;
            lblBirthday.Text = "Birthday";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJob.Location = new Point(32, 83);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(43, 28);
            lblJob.TabIndex = 34;
            lblJob.Text = "Job";
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonName.Location = new Point(32, 34);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(64, 28);
            lblPersonName.TabIndex = 33;
            lblPersonName.Text = "Name";
            // 
            // cmbCollar
            // 
            cmbCollar.BackColor = Color.SeaShell;
            cmbCollar.Font = new Font("Segoe UI", 12F);
            cmbCollar.FormattingEnabled = true;
            cmbCollar.Location = new Point(147, 273);
            cmbCollar.Name = "cmbCollar";
            cmbCollar.Size = new Size(151, 36);
            cmbCollar.TabIndex = 29;
            // 
            // txtComm
            // 
            txtComm.AcceptsReturn = true;
            txtComm.BackColor = Color.SeaShell;
            txtComm.Font = new Font("Segoe UI", 12F);
            txtComm.Location = new Point(160, 224);
            txtComm.Name = "txtComm";
            txtComm.Size = new Size(125, 34);
            txtComm.TabIndex = 28;
            // 
            // txtSalary
            // 
            txtSalary.AcceptsReturn = true;
            txtSalary.BackColor = Color.SeaShell;
            txtSalary.Font = new Font("Segoe UI", 12F);
            txtSalary.Location = new Point(160, 176);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 34);
            txtSalary.TabIndex = 27;
            // 
            // txtBirthday
            // 
            txtBirthday.AcceptsReturn = true;
            txtBirthday.BackColor = Color.SeaShell;
            txtBirthday.Font = new Font("Segoe UI", 12F);
            txtBirthday.Location = new Point(160, 126);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(125, 34);
            txtBirthday.TabIndex = 26;
            // 
            // txtJob
            // 
            txtJob.AcceptsReturn = true;
            txtJob.BackColor = Color.SeaShell;
            txtJob.Font = new Font("Segoe UI", 12F);
            txtJob.Location = new Point(160, 77);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(125, 34);
            txtJob.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.BackColor = Color.SeaShell;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(160, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 34);
            txtName.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(147, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 41);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMessages
            // 
            txtMessages.BackColor = Color.SeaShell;
            txtMessages.Location = new Point(338, 126);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.Size = new Size(210, 290);
            txtMessages.TabIndex = 41;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(32, 332);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 43;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.SeaShell;
            cmbGender.Font = new Font("Segoe UI", 12F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "F", "M" });
            cmbGender.Location = new Point(147, 326);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 36);
            cmbGender.TabIndex = 42;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Salmon;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(495, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(82, 41);
            btnQuit.TabIndex = 44;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(589, 465);
            Controls.Add(btnQuit);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(txtMessages);
            Controls.Add(btnAdd);
            Controls.Add(lblCollar);
            Controls.Add(lblComm);
            Controls.Add(lblSalary);
            Controls.Add(lblBirthday);
            Controls.Add(lblJob);
            Controls.Add(lblPersonName);
            Controls.Add(cmbCollar);
            Controls.Add(txtComm);
            Controls.Add(txtSalary);
            Controls.Add(txtBirthday);
            Controls.Add(txtJob);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            Load += AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCollar;
        private Label lblComm;
        private Label lblSalary;
        private Label lblBirthday;
        private Label lblJob;
        private Label lblPersonName;
        private ComboBox cmbCollar;
        private TextBox txtComm;
        private TextBox txtSalary;
        private TextBox txtBirthday;
        private TextBox txtJob;
        private TextBox txtName;
        private Button btnAdd;
        private TextBox txtMessages;
        private Label lblGender;
        private ComboBox cmbGender;
        private Button btnQuit;
    }
}