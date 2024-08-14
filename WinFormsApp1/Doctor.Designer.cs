namespace WinFormsApp1
{
    partial class Doctor
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            licenceTextBox = new TextBox();
            expTextBox = new TextBox();
            doctorNameTextBox = new TextBox();
            GenderComboBox = new ComboBox();
            DelBtn = new Button();
            AddBtn = new Button();
            UpdateBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
            pictureBox2.Location = new Point(-3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 76);
            label1.Name = "label1";
            label1.Size = new Size(167, 43);
            label1.TabIndex = 5;
            label1.Text = "DOCTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 165);
            label3.Name = "label3";
            label3.Size = new Size(225, 38);
            label3.TabIndex = 7;
            label3.Text = " DOCTOR NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(459, 165);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 8;
            label4.Text = " GENDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(668, 165);
            label5.Name = "label5";
            label5.Size = new Size(306, 38);
            label5.TabIndex = 9;
            label5.Text = "YEARS OF EXPERIENCE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1046, 165);
            label6.Name = "label6";
            label6.Size = new Size(390, 38);
            label6.TabIndex = 10;
            label6.Text = "MEDICAL LICENSCE NUMBER";
            // 
            // licenceTextBox
            // 
            licenceTextBox.BackColor = SystemColors.ButtonHighlight;
            licenceTextBox.Location = new Point(1046, 215);
            licenceTextBox.Name = "licenceTextBox";
            licenceTextBox.Size = new Size(390, 27);
            licenceTextBox.TabIndex = 12;
            // 
            // expTextBox
            // 
            expTextBox.BackColor = SystemColors.ButtonHighlight;
            expTextBox.Location = new Point(668, 215);
            expTextBox.Name = "expTextBox";
            expTextBox.Size = new Size(306, 27);
            expTextBox.TabIndex = 13;
            // 
            // doctorNameTextBox
            // 
            doctorNameTextBox.BackColor = SystemColors.ButtonHighlight;
            doctorNameTextBox.Location = new Point(200, 215);
            doctorNameTextBox.Name = "doctorNameTextBox";
            doctorNameTextBox.Size = new Size(225, 27);
            doctorNameTextBox.TabIndex = 15;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE " });
            GenderComboBox.Location = new Point(459, 214);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(133, 28);
            GenderComboBox.TabIndex = 16;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = SystemColors.ActiveCaptionText;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = SystemColors.ButtonHighlight;
            DelBtn.Location = new Point(445, 644);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(125, 56);
            DelBtn.TabIndex = 18;
            DelBtn.Text = "DELETE";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaptionText;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(23, 644);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(125, 56);
            AddBtn.TabIndex = 19;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveCaptionText;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.Location = new Point(234, 644);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(125, 56);
            UpdateBtn.TabIndex = 20;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ActiveCaptionText;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = SystemColors.ButtonHighlight;
            ResetBtn.Location = new Point(685, 644);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(125, 56);
            ResetBtn.TabIndex = 21;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = SystemColors.ActiveCaptionText;
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = SystemColors.ButtonHighlight;
            HomeBtn.Location = new Point(899, 644);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(125, 56);
            HomeBtn.TabIndex = 22;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = SystemColors.ActiveCaptionText;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = SystemColors.ButtonHighlight;
            CrossBtn.Location = new Point(1401, 12);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(59, 56);
            CrossBtn.TabIndex = 23;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1490, 689);
            Controls.Add(CrossBtn);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(DelBtn);
            Controls.Add(GenderComboBox);
            Controls.Add(doctorNameTextBox);
            Controls.Add(expTextBox);
            Controls.Add(licenceTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            Text = "  ";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox licenceTextBox;
        private TextBox expTextBox;
        private TextBox doctorNameTextBox;
        private ComboBox GenderComboBox;
        private Button DelBtn;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private Button CrossBtn;
    }
}