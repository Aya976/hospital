using System.Windows.Forms;

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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
            pictureBox2.Location = new Point(-3, 1);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 57);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 5;
            label1.Text = "DOCTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 124);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 7;
            label3.Text = " DOCTOR NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(402, 124);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 8;
            label4.Text = " GENDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(584, 124);
            label5.Name = "label5";
            label5.Size = new Size(240, 30);
            label5.TabIndex = 9;
            label5.Text = "YEARS OF EXPERIENCE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(915, 124);
            label6.Name = "label6";
            label6.Size = new Size(304, 30);
            label6.TabIndex = 10;
            label6.Text = "MEDICAL LICENSCE NUMBER";
            // 
            // licenceTextBox
            // 
            licenceTextBox.BackColor = SystemColors.ButtonHighlight;
            licenceTextBox.Location = new Point(915, 161);
            licenceTextBox.Margin = new Padding(4, 4, 4, 4);
            licenceTextBox.Name = "licenceTextBox";
            licenceTextBox.Size = new Size(553, 23);
            licenceTextBox.TabIndex = 12;
            // 
            // expTextBox
            // 
            expTextBox.BackColor = SystemColors.ButtonHighlight;
            expTextBox.Location = new Point(584, 161);
            expTextBox.Margin = new Padding(3, 2, 3, 2);
            expTextBox.Name = "expTextBox";
            expTextBox.Size = new Size(268, 23);
            expTextBox.TabIndex = 13;
            // 
            // doctorNameTextBox
            // 
            doctorNameTextBox.BackColor = SystemColors.ButtonHighlight;
            doctorNameTextBox.Location = new Point(175, 161);
            doctorNameTextBox.Margin = new Padding(3, 2, 3, 2);
            doctorNameTextBox.Name = "doctorNameTextBox";
            doctorNameTextBox.Size = new Size(197, 23);
            doctorNameTextBox.TabIndex = 15;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE " });
            GenderComboBox.Location = new Point(402, 160);
            GenderComboBox.Margin = new Padding(3, 2, 3, 2);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(117, 23);
            GenderComboBox.TabIndex = 16;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = SystemColors.ActiveCaptionText;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = SystemColors.ButtonHighlight;
            DelBtn.Location = new Point(389, 483);
            DelBtn.Margin = new Padding(3, 2, 3, 2);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(109, 42);
            DelBtn.TabIndex = 18;
            DelBtn.Text = "DELETE";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaptionText;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(20, 483);
            AddBtn.Margin = new Padding(3, 2, 3, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(109, 42);
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
            UpdateBtn.Location = new Point(205, 483);
            UpdateBtn.Margin = new Padding(3, 2, 3, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(109, 42);
            UpdateBtn.TabIndex = 20;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ActiveCaptionText;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = SystemColors.ButtonHighlight;
            ResetBtn.Location = new Point(599, 483);
            ResetBtn.Margin = new Padding(3, 2, 3, 2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(109, 42);
            ResetBtn.TabIndex = 21;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = SystemColors.ActiveCaptionText;
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = SystemColors.ButtonHighlight;
            HomeBtn.Location = new Point(787, 483);
            HomeBtn.Margin = new Padding(3, 2, 3, 2);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(109, 42);
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
            CrossBtn.Location = new Point(1226, 9);
            CrossBtn.Margin = new Padding(3, 2, 3, 2);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(52, 42);
            CrossBtn.TabIndex = 23;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 328);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1891, 406);
            dataGridView1.TabIndex = 24;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 264);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 57);
            label2.TabIndex = 25;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(17, 342);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(69, 128);
            label7.Name = "label7";
            label7.Size = new Size(41, 30);
            label7.TabIndex = 25;
            label7.Text = " ID";
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1304, 517);
            Controls.Add(label7);
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
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Doctor";
            Text = "  ";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label label7;
    }
}