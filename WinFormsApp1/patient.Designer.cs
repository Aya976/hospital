namespace WinFormsApp1
{
    partial class patient
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
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DelBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            dataGridView2 = new DataGridView();
            CrossBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.patient;
            pictureBox5.Location = new Point(0, -1);
            pictureBox5.Margin = new Padding(5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(208, 184);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 116);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 67);
            label1.TabIndex = 8;
            label1.Text = "PATIENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 309);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 57);
            label2.TabIndex = 26;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 460);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 57);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 591);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 57);
            label4.TabIndex = 30;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 735);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 57);
            label5.TabIndex = 33;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(848, 316);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 57);
            label6.TabIndex = 34;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(835, 448);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 57);
            label7.TabIndex = 36;
            label7.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female\t" });
            comboBox1.Location = new Point(1097, 467);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 40);
            comboBox1.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(771, 584);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(287, 57);
            label8.TabIndex = 38;
            label8.Text = "Blood Group";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B+", "O+", "B-", "A-", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(1097, 599);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(338, 40);
            comboBox2.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(764, 713);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(327, 57);
            label9.TabIndex = 40;
            label9.Text = "Major Disease ";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaptionText;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(1853, 308);
            AddBtn.Margin = new Padding(5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(203, 90);
            AddBtn.TabIndex = 42;
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
            UpdateBtn.Location = new Point(1853, 430);
            UpdateBtn.Margin = new Padding(5);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(203, 90);
            UpdateBtn.TabIndex = 43;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = SystemColors.ActiveCaptionText;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = SystemColors.ButtonHighlight;
            DelBtn.Location = new Point(1853, 565);
            DelBtn.Margin = new Padding(5);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(203, 90);
            DelBtn.TabIndex = 44;
            DelBtn.Text = "DELETE";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ActiveCaptionText;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = SystemColors.ButtonHighlight;
            ResetBtn.Location = new Point(1853, 691);
            ResetBtn.Margin = new Padding(5);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(203, 90);
            ResetBtn.TabIndex = 45;
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
            HomeBtn.Location = new Point(1853, 824);
            HomeBtn.Margin = new Padding(5);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(203, 90);
            HomeBtn.TabIndex = 46;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 823);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1818, 545);
            dataGridView2.TabIndex = 47;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = SystemColors.ActiveCaptionText;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = SystemColors.ButtonHighlight;
            CrossBtn.Location = new Point(2099, 3);
            CrossBtn.Margin = new Padding(5);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(96, 90);
            CrossBtn.TabIndex = 48;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 39);
            textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 471);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 39);
            textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 609);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 39);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(299, 752);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 39);
            textBox4.TabIndex = 52;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1097, 328);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(338, 39);
            textBox5.TabIndex = 53;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1097, 721);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(338, 39);
            textBox6.TabIndex = 54;
            // 
            // patient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(2198, 1380);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CrossBtn);
            Controls.Add(dataGridView2);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "patient";
            Load += patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DelBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private DataGridView dataGridView2;
        private Button CrossBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}