namespace Company
{
    partial class ManagerToEmployee
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
            cmbEmployeeName = new ComboBox();
            txtSentMail = new TextBox();
            SuspendLayout();
            // 
            // lblToWho
            // 
            lblToWho.AutoSize = true;
            lblToWho.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToWho.Location = new Point(938, 20);
            lblToWho.Name = "lblToWho";
            lblToWho.Size = new Size(90, 31);
            lblToWho.TabIndex = 7;
            lblToWho.Text = "To Who";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1034, 83);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 53);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cmbEmployeeName
            // 
            cmbEmployeeName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmployeeName.FormattingEnabled = true;
            cmbEmployeeName.Location = new Point(1034, 12);
            cmbEmployeeName.Name = "cmbEmployeeName";
            cmbEmployeeName.Size = new Size(171, 45);
            cmbEmployeeName.TabIndex = 5;
            // 
            // txtSentMail
            // 
            txtSentMail.BackColor = Color.LightYellow;
            txtSentMail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSentMail.Location = new Point(12, 12);
            txtSentMail.Multiline = true;
            txtSentMail.Name = "txtSentMail";
            txtSentMail.Size = new Size(920, 395);
            txtSentMail.TabIndex = 4;
            // 
            // ManagerToEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1229, 425);
            Controls.Add(lblToWho);
            Controls.Add(btnSend);
            Controls.Add(cmbEmployeeName);
            Controls.Add(txtSentMail);
            Name = "ManagerToEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerToEmployee";
            Load += ManagerToEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblToWho;
        private Button btnSend;
        private ComboBox cmbEmployeeName;
        private TextBox txtSentMail;
    }
}