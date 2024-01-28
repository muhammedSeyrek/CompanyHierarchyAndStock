namespace Company
{
    partial class EmployeeJobApplication
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
            txtMessageBox = new TextBox();
            btnSent = new Button();
            cmbBranch = new ComboBox();
            lblWhichBranch = new Label();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // txtMessageBox
            // 
            txtMessageBox.BackColor = Color.SeaShell;
            txtMessageBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessageBox.Location = new Point(12, 12);
            txtMessageBox.Multiline = true;
            txtMessageBox.Name = "txtMessageBox";
            txtMessageBox.Size = new Size(648, 470);
            txtMessageBox.TabIndex = 0;
            // 
            // btnSent
            // 
            btnSent.BackColor = Color.MediumSeaGreen;
            btnSent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSent.Location = new Point(850, 84);
            btnSent.Name = "btnSent";
            btnSent.Size = new Size(150, 45);
            btnSent.TabIndex = 1;
            btnSent.Text = "Apply";
            btnSent.UseVisualStyleBackColor = false;
            btnSent.Click += btnSent_Click;
            // 
            // cmbBranch
            // 
            cmbBranch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(849, 24);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(151, 39);
            cmbBranch.TabIndex = 2;
            // 
            // lblWhichBranch
            // 
            lblWhichBranch.AutoSize = true;
            lblWhichBranch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWhichBranch.Location = new Point(676, 27);
            lblWhichBranch.Name = "lblWhichBranch";
            lblWhichBranch.Size = new Size(154, 31);
            lblWhichBranch.TabIndex = 3;
            lblWhichBranch.Text = "Which Branch";
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Salmon;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(936, 430);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(64, 52);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // EmployeeJobApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1013, 490);
            Controls.Add(btnQuit);
            Controls.Add(lblWhichBranch);
            Controls.Add(cmbBranch);
            Controls.Add(btnSent);
            Controls.Add(txtMessageBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeJobApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeJobApplication";
            Load += EmployeeJobApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMessageBox;
        private Button btnSent;
        private ComboBox cmbBranch;
        private Label lblWhichBranch;
        private Button btnQuit;
    }
}