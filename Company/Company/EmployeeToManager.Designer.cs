namespace Company
{
    partial class EmployeeToManager
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
            btnSend = new Button();
            txtSentMail = new TextBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(1041, 354);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 53);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtSentMail
            // 
            txtSentMail.BackColor = Color.FloralWhite;
            txtSentMail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSentMail.Location = new Point(12, 12);
            txtSentMail.Multiline = true;
            txtSentMail.Name = "txtSentMail";
            txtSentMail.Size = new Size(1016, 395);
            txtSentMail.TabIndex = 8;
            // 
            // EmployeeToManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1224, 423);
            Controls.Add(btnSend);
            Controls.Add(txtSentMail);
            Name = "EmployeeToManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeToManager";
            Load += EmployeeToManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtSentMail;
    }
}