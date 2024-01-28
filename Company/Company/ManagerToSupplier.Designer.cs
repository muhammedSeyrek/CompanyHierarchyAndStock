namespace Company
{
    partial class ManagerToSupplier
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
            txtSentMail = new TextBox();
            cmbBoxSupplierName = new ComboBox();
            btnSend = new Button();
            lblToWho = new Label();
            SuspendLayout();
            // 
            // txtSentMail
            // 
            txtSentMail.BackColor = Color.LightYellow;
            txtSentMail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSentMail.Location = new Point(9, 12);
            txtSentMail.Multiline = true;
            txtSentMail.Name = "txtSentMail";
            txtSentMail.Size = new Size(920, 395);
            txtSentMail.TabIndex = 0;
            // 
            // cmbBoxSupplierName
            // 
            cmbBoxSupplierName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxSupplierName.FormattingEnabled = true;
            cmbBoxSupplierName.Location = new Point(1031, 12);
            cmbBoxSupplierName.Name = "cmbBoxSupplierName";
            cmbBoxSupplierName.Size = new Size(171, 45);
            cmbBoxSupplierName.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1031, 83);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 53);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblToWho
            // 
            lblToWho.AutoSize = true;
            lblToWho.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToWho.Location = new Point(935, 20);
            lblToWho.Name = "lblToWho";
            lblToWho.Size = new Size(90, 31);
            lblToWho.TabIndex = 3;
            lblToWho.Text = "To Who";
            // 
            // ManagerToSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1223, 424);
            Controls.Add(lblToWho);
            Controls.Add(btnSend);
            Controls.Add(cmbBoxSupplierName);
            Controls.Add(txtSentMail);
            ForeColor = SystemColors.ControlText;
            Name = "ManagerToSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerToSupplier";
            Load += ManagerToSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSentMail;
        private ComboBox cmbBoxSupplierName;
        private Button btnSend;
        private Label lblToWho;
    }
}