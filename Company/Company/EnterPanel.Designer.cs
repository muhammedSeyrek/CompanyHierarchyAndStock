namespace Company
{
    partial class EnterPanel
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
            txtPassword = new TextBox();
            btnEnter = new Button();
            menuStrip1 = new MenuStrip();
            brandToolStripMenuItem = new ToolStripMenuItem();
            managerLogInToolStripMenuItem = new ToolStripMenuItem();
            employeeLogInToolStripMenuItem = new ToolStripMenuItem();
            supplierLogInToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            txtMail = new TextBox();
            lblMailAddress = new Label();
            lblPassword = new Label();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(477, 183);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(169, 41);
            txtPassword.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(477, 250);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(169, 41);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PapayaWhip;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { brandToolStripMenuItem, managerLogInToolStripMenuItem, employeeLogInToolStripMenuItem, supplierLogInToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 46);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // brandToolStripMenuItem
            // 
            brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            brandToolStripMenuItem.Size = new Size(187, 42);
            brandToolStripMenuItem.Text = "Brand Log In";
            brandToolStripMenuItem.Click += brandToolStripMenuItem_Click;
            // 
            // managerLogInToolStripMenuItem
            // 
            managerLogInToolStripMenuItem.Name = "managerLogInToolStripMenuItem";
            managerLogInToolStripMenuItem.Size = new Size(225, 42);
            managerLogInToolStripMenuItem.Text = "Manager Log In";
            managerLogInToolStripMenuItem.Click += managerLogInToolStripMenuItem_Click_1;
            // 
            // employeeLogInToolStripMenuItem
            // 
            employeeLogInToolStripMenuItem.Name = "employeeLogInToolStripMenuItem";
            employeeLogInToolStripMenuItem.Size = new Size(236, 42);
            employeeLogInToolStripMenuItem.Text = "Employee Log In";
            employeeLogInToolStripMenuItem.Click += employeeLogInToolStripMenuItem_Click;
            // 
            // supplierLogInToolStripMenuItem
            // 
            supplierLogInToolStripMenuItem.Name = "supplierLogInToolStripMenuItem";
            supplierLogInToolStripMenuItem.Size = new Size(217, 42);
            supplierLogInToolStripMenuItem.Text = "Supplier Log In";
            supplierLogInToolStripMenuItem.Click += supplierLogInToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = Color.SandyBrown;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(84, 42);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Tan;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { employeeToolStripMenuItem });
            menuStrip2.Location = new Point(9, 291);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(195, 39);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.BackColor = Color.PeachPuff;
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(187, 35);
            employeeToolStripMenuItem.Text = "Job Application";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(477, 123);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(169, 41);
            txtMail.TabIndex = 5;
            // 
            // lblMailAddress
            // 
            lblMailAddress.AutoSize = true;
            lblMailAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMailAddress.Location = new Point(310, 126);
            lblMailAddress.Name = "lblMailAddress";
            lblMailAddress.Size = new Size(148, 31);
            lblMailAddress.TabIndex = 6;
            lblMailAddress.Text = "Mail Address";
            lblMailAddress.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(348, 186);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 31);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // EnterPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(962, 339);
            Controls.Add(lblPassword);
            Controls.Add(lblMailAddress);
            Controls.Add(txtMail);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "EnterPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterPanel";
            Load += EnterPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnEnter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem brandToolStripMenuItem;
        private ToolStripMenuItem managerLogInToolStripMenuItem;
        private ToolStripMenuItem employeeLogInToolStripMenuItem;
        private ToolStripMenuItem supplierLogInToolStripMenuItem;
        private MenuStrip menuStrip2;
        private TextBox txtMail;
        private Label lblMailAddress;
        private Label lblPassword;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
    }
}