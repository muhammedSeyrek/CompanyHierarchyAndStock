namespace Company
{
    partial class AddProduct
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
            lblProductName = new Label();
            lblCategory = new Label();
            lblPurchase = new Label();
            txtProductName = new TextBox();
            txtPurchasePrice = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 16.2F);
            lblProductName.Location = new Point(26, 157);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(195, 38);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 16.2F);
            lblCategory.Location = new Point(96, 213);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(128, 38);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblPurchase
            // 
            lblPurchase.AutoSize = true;
            lblPurchase.Font = new Font("Segoe UI", 16.2F);
            lblPurchase.Location = new Point(26, 271);
            lblPurchase.Name = "lblPurchase";
            lblPurchase.Size = new Size(198, 38);
            lblPurchase.TabIndex = 2;
            lblPurchase.Text = "Purchase Price";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 16.2F);
            txtProductName.Location = new Point(249, 157);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(165, 43);
            txtProductName.TabIndex = 3;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Font = new Font("Segoe UI", 16.2F);
            txtPurchasePrice.Location = new Point(249, 271);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(165, 43);
            txtPurchasePrice.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(249, 213);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(165, 45);
            cmbCategory.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.BurlyWood;
            btnAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(249, 334);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 47);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Salmon;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(353, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(82, 41);
            btnQuit.TabIndex = 45;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(451, 434);
            Controls.Add(btnQuit);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtProductName);
            Controls.Add(lblPurchase);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblCategory;
        private Label lblPurchase;
        private TextBox txtProductName;
        private TextBox txtPurchasePrice;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnQuit;
    }
}