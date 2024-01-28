namespace Company
{
    partial class SupplierToEmployee
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
            txtSent = new TextBox();
            cmbEmployee = new ComboBox();
            btnQuit = new Button();
            lblChooseEmployee = new Label();
            btnSent = new Button();
            SuspendLayout();
            // 
            // txtSent
            // 
            txtSent.BackColor = Color.Linen;
            txtSent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSent.Location = new Point(12, 12);
            txtSent.Multiline = true;
            txtSent.Name = "txtSent";
            txtSent.Size = new Size(1078, 508);
            txtSent.TabIndex = 0;
            // 
            // cmbEmployee
            // 
            cmbEmployee.BackColor = Color.AntiqueWhite;
            cmbEmployee.Font = new Font("Segoe UI", 12F);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(1274, 93);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(155, 36);
            cmbEmployee.TabIndex = 2;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.IndianRed;
            btnQuit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(1300, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(130, 46);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblChooseEmployee
            // 
            lblChooseEmployee.AutoSize = true;
            lblChooseEmployee.Font = new Font("Segoe UI", 12F);
            lblChooseEmployee.Location = new Point(1096, 96);
            lblChooseEmployee.Name = "lblChooseEmployee";
            lblChooseEmployee.Size = new Size(168, 28);
            lblChooseEmployee.TabIndex = 5;
            lblChooseEmployee.Text = "Choose Employee";
            // 
            // btnSent
            // 
            btnSent.BackColor = Color.DarkOrange;
            btnSent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSent.Location = new Point(1274, 156);
            btnSent.Name = "btnSent";
            btnSent.Size = new Size(156, 39);
            btnSent.TabIndex = 6;
            btnSent.Text = "Sent";
            btnSent.UseVisualStyleBackColor = false;
            btnSent.Click += btnSent_Click;
            // 
            // SupplierToEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1442, 532);
            Controls.Add(btnSent);
            Controls.Add(lblChooseEmployee);
            Controls.Add(btnQuit);
            Controls.Add(cmbEmployee);
            Controls.Add(txtSent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierToEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierToEmployee";
            Load += SupplierToEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSent;
        private ComboBox cmbEmployee;
        private Button btnQuit;
        private Label lblChooseEmployee;
        private Button btnSent;
    }
}