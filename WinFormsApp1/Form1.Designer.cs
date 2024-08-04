namespace WinFormsApp1
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Admin = new RichTextBox();
            Password = new RichTextBox();
            LoginBtn = new Button();
            ClrBtn = new Button();
            CrossBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 42);
            label1.Name = "label1";
            label1.Size = new Size(374, 29);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL MANGMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 247);
            label2.Name = "label2";
            label2.Size = new Size(93, 29);
            label2.TabIndex = 1;
            label2.Text = "Admin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 313);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // Admin
            // 
            Admin.Location = new Point(145, 235);
            Admin.Name = "Admin";
            Admin.Size = new Size(378, 57);
            Admin.TabIndex = 3;
            Admin.Text = "";
            // 
            // Password
            // 
            Password.Location = new Point(145, 305);
            Password.Name = "Password";
            Password.Size = new Size(378, 57);
            Password.TabIndex = 4;
            Password.Text = "";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveCaptionText;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(201, 416);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(125, 56);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ClrBtn
            // 
            ClrBtn.BackColor = SystemColors.ActiveCaptionText;
            ClrBtn.FlatStyle = FlatStyle.Popup;
            ClrBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClrBtn.ForeColor = SystemColors.ButtonHighlight;
            ClrBtn.Location = new Point(201, 513);
            ClrBtn.Name = "ClrBtn";
            ClrBtn.Size = new Size(125, 56);
            ClrBtn.TabIndex = 6;
            ClrBtn.Text = "CLEAR";
            ClrBtn.UseVisualStyleBackColor = false;
            ClrBtn.Click += ClrBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = SystemColors.ActiveCaptionText;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = SystemColors.ButtonHighlight;
            CrossBtn.Location = new Point(503, 8);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(59, 56);
            CrossBtn.TabIndex = 7;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(572, 652);
            Controls.Add(CrossBtn);
            Controls.Add(ClrBtn);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(Admin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox Admin;
        private RichTextBox Password;
        private Button LoginBtn;
        private Button ClrBtn;
        private Button CrossBtn;
    }
}
