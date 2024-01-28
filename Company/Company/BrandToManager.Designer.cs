namespace Company
{
    partial class BrandToManager
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
            lblToWho = new Label();
            btnSend = new Button();
            cmbManagerName = new ComboBox();
            txtSentMail = new TextBox();
            SuspendLayout();
            // 
            // lblToWho
            // 
            lblToWho.AutoSize = true;
            lblToWho.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToWho.Location = new Point(944, 23);
            lblToWho.Name = "lblToWho";
            lblToWho.Size = new Size(90, 31);
            lblToWho.TabIndex = 11;
            lblToWho.Text = "To Who";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1040, 86);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 53);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cmbManagerName
            // 
            cmbManagerName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbManagerName.FormattingEnabled = true;
            cmbManagerName.Location = new Point(1040, 15);
            cmbManagerName.Name = "cmbManagerName";
            cmbManagerName.Size = new Size(171, 45);
            cmbManagerName.TabIndex = 9;
            // 
            // txtSentMail
            // 
            txtSentMail.BackColor = SystemColors.ControlLight;
            txtSentMail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSentMail.Location = new Point(18, 15);
            txtSentMail.Multiline = true;
            txtSentMail.Name = "txtSentMail";
            txtSentMail.Size = new Size(920, 395);
            txtSentMail.TabIndex = 8;
            // 
            // BrandToManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1229, 425);
            Controls.Add(lblToWho);
            Controls.Add(btnSend);
            Controls.Add(cmbManagerName);
            Controls.Add(txtSentMail);
            Name = "BrandToManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrandToManager";
            Load += BrandToManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblToWho;
        private Button btnSend;
        private ComboBox cmbManagerName;
        private TextBox txtSentMail;
    }
}