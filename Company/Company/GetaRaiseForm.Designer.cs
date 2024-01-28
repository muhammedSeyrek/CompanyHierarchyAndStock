namespace Company
{
    partial class GetaRaiseForm
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
            dataGridView1 = new DataGridView();
            lblRaise = new Label();
            txtRaise = new TextBox();
            btnRaise = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkKhaki;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1331, 468);
            dataGridView1.TabIndex = 0;
            // 
            // lblRaise
            // 
            lblRaise.AutoSize = true;
            lblRaise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRaise.Location = new Point(12, 9);
            lblRaise.Name = "lblRaise";
            lblRaise.Size = new Size(115, 28);
            lblRaise.TabIndex = 1;
            lblRaise.Text = "Enter Salary";
            // 
            // txtRaise
            // 
            txtRaise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRaise.Location = new Point(151, 9);
            txtRaise.Name = "txtRaise";
            txtRaise.Size = new Size(125, 34);
            txtRaise.TabIndex = 2;
            // 
            // btnRaise
            // 
            btnRaise.BackColor = Color.MediumSeaGreen;
            btnRaise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaise.Location = new Point(320, 7);
            btnRaise.Name = "btnRaise";
            btnRaise.Size = new Size(125, 39);
            btnRaise.TabIndex = 3;
            btnRaise.Text = "Raise";
            btnRaise.UseVisualStyleBackColor = false;
            btnRaise.Click += btnRaise_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Red;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(1273, 9);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(70, 37);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // GetaRaiseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1355, 532);
            Controls.Add(btnQuit);
            Controls.Add(btnRaise);
            Controls.Add(txtRaise);
            Controls.Add(lblRaise);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GetaRaiseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GetaRaiseForm";
            Load += GetaRaiseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblRaise;
        private TextBox txtRaise;
        private Button btnRaise;
        private Button btnQuit;
    }
}