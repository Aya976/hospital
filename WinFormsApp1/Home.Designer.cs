namespace WinFormsApp1
{
    partial class Home
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            DocBtn = new Button();
            PatientBtn = new Button();
            LogoutBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 43);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_computer_icons_home_house_home_angle_building_rectangle_thumbnail2;
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
            pictureBox2.Location = new Point(463, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.power_;
            pictureBox3.Location = new Point(462, 427);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.patient;
            pictureBox5.Location = new Point(462, 231);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 115);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // DocBtn
            // 
            DocBtn.BackColor = SystemColors.ActiveCaptionText;
            DocBtn.FlatStyle = FlatStyle.Popup;
            DocBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocBtn.ForeColor = SystemColors.ButtonHighlight;
            DocBtn.Location = new Point(629, 75);
            DocBtn.Name = "DocBtn";
            DocBtn.Size = new Size(125, 56);
            DocBtn.TabIndex = 7;
            DocBtn.Text = "Doctor";
            DocBtn.UseVisualStyleBackColor = false;
            DocBtn.Click += LoginBtn_Click;
            // 
            // PatientBtn
            // 
            PatientBtn.BackColor = SystemColors.ActiveCaptionText;
            PatientBtn.FlatStyle = FlatStyle.Popup;
            PatientBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatientBtn.ForeColor = SystemColors.ButtonHighlight;
            PatientBtn.Location = new Point(637, 258);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(125, 56);
            PatientBtn.TabIndex = 8;
            PatientBtn.Text = "Patient";
            PatientBtn.UseVisualStyleBackColor = false;
            PatientBtn.Click += PatientBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = SystemColors.ActiveCaptionText;
            LogoutBtn.FlatStyle = FlatStyle.Popup;
            LogoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = SystemColors.ButtonHighlight;
            LogoutBtn.Location = new Point(630, 445);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(125, 56);
            LogoutBtn.TabIndex = 10;
            LogoutBtn.Text = "LOGOUT";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = SystemColors.ActiveCaptionText;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = SystemColors.ButtonHighlight;
            CrossBtn.Location = new Point(995, 9);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(59, 56);
            CrossBtn.TabIndex = 11;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1062, 556);
            Controls.Add(CrossBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(PatientBtn);
            Controls.Add(DocBtn);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button DocBtn;
        private Button PatientBtn;
        private Button LogoutBtn;
        private Button CrossBtn;
    }
}