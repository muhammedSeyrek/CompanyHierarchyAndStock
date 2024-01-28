namespace Company
{
    partial class EmployeePanel
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
            menuStrip1 = new MenuStrip();
            ınToolStripMenuItem = new ToolStripMenuItem();
            sentMailToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            listProductToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            cmbCategory = new ComboBox();
            txtPurchasePrice = new TextBox();
            lblEmployeeName = new Label();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { ınToolStripMenuItem, sentMailToolStripMenuItem, addProductToolStripMenuItem, listProductToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1471, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ınToolStripMenuItem
            // 
            ınToolStripMenuItem.Name = "ınToolStripMenuItem";
            ınToolStripMenuItem.Size = new Size(85, 42);
            ınToolStripMenuItem.Text = "Inbox";
            ınToolStripMenuItem.Click += ınToolStripMenuItem_Click;
            // 
            // sentMailToolStripMenuItem
            // 
            sentMailToolStripMenuItem.Name = "sentMailToolStripMenuItem";
            sentMailToolStripMenuItem.Size = new Size(124, 42);
            sentMailToolStripMenuItem.Text = "Sent Mail";
            sentMailToolStripMenuItem.Click += sentMailToolStripMenuItem_Click;
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(157, 42);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // listProductToolStripMenuItem
            // 
            listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            listProductToolStripMenuItem.Size = new Size(149, 42);
            listProductToolStripMenuItem.Text = "List Product";
            listProductToolStripMenuItem.Click += listProductToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.BackColor = Color.Salmon;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(72, 42);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1040, 592);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 13.8F);
            txtProductName.Location = new Point(1238, 79);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(205, 38);
            txtProductName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1071, 82);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 7;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1071, 151);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 8;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1071, 220);
            label3.Name = "label3";
            label3.Size = new Size(162, 31);
            label3.TabIndex = 9;
            label3.Text = "Purchase Price";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MistyRose;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1288, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MistyRose;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(1100, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 44);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(1238, 143);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(205, 45);
            cmbCategory.TabIndex = 12;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Font = new Font("Segoe UI", 13.8F);
            txtPurchasePrice.Location = new Point(1239, 217);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(205, 38);
            txtPurchasePrice.TabIndex = 13;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(975, 82);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(0, 31);
            lblEmployeeName.TabIndex = 14;
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1471, 661);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtPurchasePrice);
            Controls.Add(cmbCategory);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "EmployeePanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Panel";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ınToolStripMenuItem;
        private ToolStripMenuItem sentMailToolStripMenuItem;
        private ToolStripMenuItem listProductToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cmbCategory;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TextBox txtPurchasePrice;
        private Label lblEmployeeName;
        private ToolStripMenuItem addProductToolStripMenuItem;
    }
}
