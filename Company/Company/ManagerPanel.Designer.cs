namespace Company
{
    partial class ManagerPanel
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
            menuStrip1 = new MenuStrip();
            ınboxToolStripMenuItem = new ToolStripMenuItem();
            sentMailToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            listEmployeeToolStripMenuItem = new ToolStripMenuItem();
            listProductToolStripMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            jobApplicationToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtPersonId = new TextBox();
            txtJob = new TextBox();
            txtBirthday = new TextBox();
            txtSalary = new TextBox();
            txtComm = new TextBox();
            cmbCollar = new ComboBox();
            txtMail = new TextBox();
            txtWorkTime = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblPersonId = new Label();
            lblPersonName = new Label();
            lblBirthday = new Label();
            lblJob = new Label();
            lblComm = new Label();
            lblSalary = new Label();
            lblCollar = new Label();
            lblMail = new Label();
            lblWorkTime = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Linen;
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ınboxToolStripMenuItem, sentMailToolStripMenuItem, listEmployeeToolStripMenuItem, listProductToolStripMenuItem, addEmployeeToolStripMenuItem, jobApplicationToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1787, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ınboxToolStripMenuItem
            // 
            ınboxToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ınboxToolStripMenuItem.Name = "ınboxToolStripMenuItem";
            ınboxToolStripMenuItem.Size = new Size(85, 44);
            ınboxToolStripMenuItem.Text = "Inbox";
            ınboxToolStripMenuItem.Click += ınboxToolStripMenuItem_Click;
            // 
            // sentMailToolStripMenuItem
            // 
            sentMailToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, supplierToolStripMenuItem });
            sentMailToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sentMailToolStripMenuItem.Name = "sentMailToolStripMenuItem";
            sentMailToolStripMenuItem.Size = new Size(124, 44);
            sentMailToolStripMenuItem.Text = "Sent Mail";
            sentMailToolStripMenuItem.Click += sentMailToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(202, 36);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(202, 36);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // listEmployeeToolStripMenuItem
            // 
            listEmployeeToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listEmployeeToolStripMenuItem.Name = "listEmployeeToolStripMenuItem";
            listEmployeeToolStripMenuItem.Size = new Size(169, 44);
            listEmployeeToolStripMenuItem.Text = "List Employee";
            listEmployeeToolStripMenuItem.Click += listEmployeeToolStripMenuItem_Click;
            // 
            // listProductToolStripMenuItem
            // 
            listProductToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            listProductToolStripMenuItem.Size = new Size(149, 44);
            listProductToolStripMenuItem.Text = "List Product";
            listProductToolStripMenuItem.Click += listProductToolStripMenuItem_Click;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(177, 44);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // jobApplicationToolStripMenuItem
            // 
            jobApplicationToolStripMenuItem.Name = "jobApplicationToolStripMenuItem";
            jobApplicationToolStripMenuItem.Size = new Size(187, 44);
            jobApplicationToolStripMenuItem.Text = "Job Application";
            jobApplicationToolStripMenuItem.Click += jobApplicationToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = Color.LightSalmon;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(72, 44);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1240, 517);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(1400, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 34);
            txtName.TabIndex = 3;
            // 
            // txtPersonId
            // 
            txtPersonId.AcceptsReturn = true;
            txtPersonId.Font = new Font("Segoe UI", 12F);
            txtPersonId.Location = new Point(1400, 70);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(224, 34);
            txtPersonId.TabIndex = 4;
            // 
            // txtJob
            // 
            txtJob.AcceptsReturn = true;
            txtJob.Font = new Font("Segoe UI", 12F);
            txtJob.Location = new Point(1400, 168);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(224, 34);
            txtJob.TabIndex = 5;
            // 
            // txtBirthday
            // 
            txtBirthday.AcceptsReturn = true;
            txtBirthday.Font = new Font("Segoe UI", 12F);
            txtBirthday.Location = new Point(1400, 217);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(224, 34);
            txtBirthday.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.AcceptsReturn = true;
            txtSalary.Font = new Font("Segoe UI", 12F);
            txtSalary.Location = new Point(1400, 267);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(224, 34);
            txtSalary.TabIndex = 7;
            // 
            // txtComm
            // 
            txtComm.AcceptsReturn = true;
            txtComm.Font = new Font("Segoe UI", 12F);
            txtComm.Location = new Point(1400, 315);
            txtComm.Name = "txtComm";
            txtComm.Size = new Size(224, 34);
            txtComm.TabIndex = 8;
            // 
            // cmbCollar
            // 
            cmbCollar.Font = new Font("Segoe UI", 12F);
            cmbCollar.FormattingEnabled = true;
            cmbCollar.Location = new Point(1400, 362);
            cmbCollar.Name = "cmbCollar";
            cmbCollar.Size = new Size(224, 36);
            cmbCollar.TabIndex = 9;
            cmbCollar.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMail
            // 
            txtMail.AcceptsReturn = true;
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(1400, 415);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(224, 34);
            txtMail.TabIndex = 10;
            // 
            // txtWorkTime
            // 
            txtWorkTime.AcceptsReturn = true;
            txtWorkTime.Font = new Font("Segoe UI", 12F);
            txtWorkTime.Location = new Point(1400, 464);
            txtWorkTime.Name = "txtWorkTime";
            txtWorkTime.Size = new Size(224, 34);
            txtWorkTime.TabIndex = 11;
            txtWorkTime.TextChanged += textBox6_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(1638, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 41);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Fire";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(1638, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 41);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonId.Location = new Point(1272, 76);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(92, 28);
            lblPersonId.TabIndex = 14;
            lblPersonId.Text = "Person Id";
            // 
            // lblPersonName
            // 
            lblPersonName.AutoSize = true;
            lblPersonName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonName.Location = new Point(1272, 125);
            lblPersonName.Name = "lblPersonName";
            lblPersonName.Size = new Size(64, 28);
            lblPersonName.TabIndex = 15;
            lblPersonName.Text = "Name";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(1272, 223);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(85, 28);
            lblBirthday.TabIndex = 17;
            lblBirthday.Text = "Birthday";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJob.Location = new Point(1272, 174);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(43, 28);
            lblJob.TabIndex = 16;
            lblJob.Text = "Job";
            // 
            // lblComm
            // 
            lblComm.AutoSize = true;
            lblComm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComm.Location = new Point(1272, 321);
            lblComm.Name = "lblComm";
            lblComm.Size = new Size(70, 28);
            lblComm.TabIndex = 19;
            lblComm.Text = "Comm";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(1272, 272);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(65, 28);
            lblSalary.TabIndex = 18;
            lblSalary.Text = "Salary";
            // 
            // lblCollar
            // 
            lblCollar.AutoSize = true;
            lblCollar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCollar.Location = new Point(1272, 370);
            lblCollar.Name = "lblCollar";
            lblCollar.Size = new Size(63, 28);
            lblCollar.TabIndex = 21;
            lblCollar.Text = "Collar";
            lblCollar.Click += label7_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(1272, 419);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(50, 28);
            lblMail.TabIndex = 20;
            lblMail.Text = "Mail";
            // 
            // lblWorkTime
            // 
            lblWorkTime.AutoSize = true;
            lblWorkTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkTime.Location = new Point(1272, 468);
            lblWorkTime.Name = "lblWorkTime";
            lblWorkTime.Size = new Size(106, 28);
            lblWorkTime.TabIndex = 22;
            lblWorkTime.Text = "Work Time";
            // 
            // ManagerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1787, 589);
            Controls.Add(lblWorkTime);
            Controls.Add(lblCollar);
            Controls.Add(lblMail);
            Controls.Add(lblComm);
            Controls.Add(lblSalary);
            Controls.Add(lblBirthday);
            Controls.Add(lblJob);
            Controls.Add(lblPersonName);
            Controls.Add(lblPersonId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtWorkTime);
            Controls.Add(txtMail);
            Controls.Add(cmbCollar);
            Controls.Add(txtComm);
            Controls.Add(txtSalary);
            Controls.Add(txtBirthday);
            Controls.Add(txtJob);
            Controls.Add(txtPersonId);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerPanel";
            Load += ManagerPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ınboxToolStripMenuItem;
        private ToolStripMenuItem sentMailToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem listEmployeeToolStripMenuItem;
        private ToolStripMenuItem listProductToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TextBox txtName;
        private TextBox txtPersonId;
        private TextBox txtJob;
        private TextBox txtBirthday;
        private TextBox txtSalary;
        private TextBox txtComm;
        private ComboBox cmbCollar;
        private TextBox txtMail;
        private TextBox txtWorkTime;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblPersonId;
        private Label lblPersonName;
        private Label lblBirthday;
        private Label lblJob;
        private Label lblComm;
        private Label lblSalary;
        private Label lblCollar;
        private Label lblMail;
        private Label lblWorkTime;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem jobApplicationToolStripMenuItem;
    }
}