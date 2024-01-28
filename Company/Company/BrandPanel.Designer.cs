namespace Company
{
    partial class BrandPanel
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
            listBranchToolStripMenuItem = new ToolStripMenuItem();
            listEmployeeToolStripMenuItem = new ToolStripMenuItem();
            listProductToolStripMenuItem = new ToolStripMenuItem();
            ınboxToolStripMenuItem = new ToolStripMenuItem();
            sentMailToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            getARaiseToolStripMenuItem = new ToolStripMenuItem();
            netWorthToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            lblBrandName = new Label();
            dataGridView1 = new DataGridView();
            lblNewBranchName = new Label();
            btnAssignment = new Button();
            lblChooseManager = new Label();
            cmbChooseManager = new ComboBox();
            txtNewBranchName = new TextBox();
            cmbChooseSupplier = new ComboBox();
            lblChooseSupplier = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.BurlyWood;
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listBranchToolStripMenuItem, listEmployeeToolStripMenuItem, listProductToolStripMenuItem, ınboxToolStripMenuItem, sentMailToolStripMenuItem, suppliersToolStripMenuItem, getARaiseToolStripMenuItem, netWorthToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1775, 74);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listBranchToolStripMenuItem
            // 
            listBranchToolStripMenuItem.Name = "listBranchToolStripMenuItem";
            listBranchToolStripMenuItem.Size = new Size(139, 70);
            listBranchToolStripMenuItem.Text = "List Branch";
            listBranchToolStripMenuItem.Click += listBranchToolStripMenuItem_Click;
            // 
            // listEmployeeToolStripMenuItem
            // 
            listEmployeeToolStripMenuItem.Name = "listEmployeeToolStripMenuItem";
            listEmployeeToolStripMenuItem.Size = new Size(169, 70);
            listEmployeeToolStripMenuItem.Text = "List Employee";
            listEmployeeToolStripMenuItem.Click += listEmployeeToolStripMenuItem_Click;
            // 
            // listProductToolStripMenuItem
            // 
            listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            listProductToolStripMenuItem.Size = new Size(149, 70);
            listProductToolStripMenuItem.Text = "List Product";
            listProductToolStripMenuItem.Click += listProductToolStripMenuItem_Click;
            // 
            // ınboxToolStripMenuItem
            // 
            ınboxToolStripMenuItem.Name = "ınboxToolStripMenuItem";
            ınboxToolStripMenuItem.Size = new Size(85, 70);
            ınboxToolStripMenuItem.Text = "Inbox";
            ınboxToolStripMenuItem.Click += ınboxToolStripMenuItem_Click;
            // 
            // sentMailToolStripMenuItem
            // 
            sentMailToolStripMenuItem.Name = "sentMailToolStripMenuItem";
            sentMailToolStripMenuItem.Size = new Size(124, 70);
            sentMailToolStripMenuItem.Text = "Sent Mail";
            sentMailToolStripMenuItem.Click += sentMailToolStripMenuItem_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(123, 70);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // getARaiseToolStripMenuItem
            // 
            getARaiseToolStripMenuItem.Name = "getARaiseToolStripMenuItem";
            getARaiseToolStripMenuItem.Size = new Size(142, 70);
            getARaiseToolStripMenuItem.Text = "Get a Raise";
            getARaiseToolStripMenuItem.Click += getARaiseToolStripMenuItem_Click;
            // 
            // netWorthToolStripMenuItem
            // 
            netWorthToolStripMenuItem.Name = "netWorthToolStripMenuItem";
            netWorthToolStripMenuItem.Size = new Size(133, 70);
            netWorthToolStripMenuItem.Text = "Net Worth";
            netWorthToolStripMenuItem.Click += netWorthToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = Color.LightSalmon;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(72, 70);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // lblBrandName
            // 
            lblBrandName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(1536, 32);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(226, 56);
            lblBrandName.TabIndex = 1;
            lblBrandName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1751, 582);
            dataGridView1.TabIndex = 2;
            // 
            // lblNewBranchName
            // 
            lblNewBranchName.AutoSize = true;
            lblNewBranchName.Location = new Point(28, 94);
            lblNewBranchName.Name = "lblNewBranchName";
            lblNewBranchName.Size = new Size(203, 31);
            lblNewBranchName.TabIndex = 3;
            lblNewBranchName.Text = "New Branch Name";
            // 
            // btnAssignment
            // 
            btnAssignment.Location = new Point(1344, 89);
            btnAssignment.Name = "btnAssignment";
            btnAssignment.Size = new Size(167, 40);
            btnAssignment.TabIndex = 4;
            btnAssignment.Text = "Assignment";
            btnAssignment.UseVisualStyleBackColor = true;
            btnAssignment.Click += btnAssignment_Click;
            // 
            // lblChooseManager
            // 
            lblChooseManager.AutoSize = true;
            lblChooseManager.Location = new Point(456, 94);
            lblChooseManager.Name = "lblChooseManager";
            lblChooseManager.Size = new Size(187, 31);
            lblChooseManager.TabIndex = 5;
            lblChooseManager.Text = "Choose Manager";
            // 
            // cmbChooseManager
            // 
            cmbChooseManager.FormattingEnabled = true;
            cmbChooseManager.Location = new Point(668, 90);
            cmbChooseManager.Name = "cmbChooseManager";
            cmbChooseManager.Size = new Size(207, 39);
            cmbChooseManager.TabIndex = 6;
            // 
            // txtNewBranchName
            // 
            txtNewBranchName.Location = new Point(256, 90);
            txtNewBranchName.Name = "txtNewBranchName";
            txtNewBranchName.Size = new Size(175, 38);
            txtNewBranchName.TabIndex = 7;
            // 
            // cmbChooseSupplier
            // 
            cmbChooseSupplier.FormattingEnabled = true;
            cmbChooseSupplier.Location = new Point(1112, 90);
            cmbChooseSupplier.Name = "cmbChooseSupplier";
            cmbChooseSupplier.Size = new Size(207, 39);
            cmbChooseSupplier.TabIndex = 9;
            // 
            // lblChooseSupplier
            // 
            lblChooseSupplier.AutoSize = true;
            lblChooseSupplier.Location = new Point(900, 94);
            lblChooseSupplier.Name = "lblChooseSupplier";
            lblChooseSupplier.Size = new Size(180, 31);
            lblChooseSupplier.TabIndex = 8;
            lblChooseSupplier.Text = "Choose Supplier";
            // 
            // BrandPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1775, 750);
            Controls.Add(cmbChooseSupplier);
            Controls.Add(lblChooseSupplier);
            Controls.Add(txtNewBranchName);
            Controls.Add(cmbChooseManager);
            Controls.Add(lblChooseManager);
            Controls.Add(btnAssignment);
            Controls.Add(lblNewBranchName);
            Controls.Add(dataGridView1);
            Controls.Add(lblBrandName);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "BrandPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrandPanel";
            Load += BrandPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listBranchToolStripMenuItem;
        private ToolStripMenuItem listEmployeeToolStripMenuItem;
        private ToolStripMenuItem listProductToolStripMenuItem;
        private ToolStripMenuItem ınboxToolStripMenuItem;
        private ToolStripMenuItem sentMailToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem netWorthToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label lblBrandName;
        private DataGridView dataGridView1;
        private Label lblNewBranchName;
        private Button btnAssignment;
        private Label lblChooseManager;
        private ComboBox cmbChooseManager;
        private TextBox txtNewBranchName;
        private ComboBox cmbChooseSupplier;
        private Label lblChooseSupplier;
        private ToolStripMenuItem getARaiseToolStripMenuItem;
    }
}