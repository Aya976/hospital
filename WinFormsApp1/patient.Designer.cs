namespace WinFormsApp1
{
    partial class Patient
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
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(112, 86);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 54);
            label1.Name = "label1";
            label1.Size = new Size(128, 35);
            label1.TabIndex = 8;
            label1.Text = "PATIENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 145);
            label2.Name = "label2";
            label2.Size = new Size(36, 30);
            label2.TabIndex = 26;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 216);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 277);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 30;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 345);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 33;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(457, 148);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 34;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(450, 210);
            label7.Name = "label7";
            label7.Size = new Size(89, 30);
            label7.TabIndex = 36;
            label7.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female\t" });
            comboBox1.Location = new Point(591, 219);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(415, 274);
            label8.Name = "label8";
            label8.Size = new Size(148, 30);
            label8.TabIndex = 38;
            label8.Text = "Blood Group";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B+", "O+", "B-", "A-", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(591, 281);
            comboBox2.Margin = new Padding(2, 1, 2, 1);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 23);
            comboBox2.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(411, 334);
            label9.Name = "label9";
            label9.Size = new Size(168, 30);
            label9.TabIndex = 40;
            label9.Text = "Major Disease ";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaptionText;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(998, 144);
            AddBtn.Margin = new Padding(3, 2, 3, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(109, 42);
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
            UpdateBtn.Location = new Point(998, 202);
            UpdateBtn.Margin = new Padding(3, 2, 3, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(109, 42);
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
            DelBtn.Location = new Point(998, 265);
            DelBtn.Margin = new Padding(3, 2, 3, 2);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(109, 42);
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
            ResetBtn.Location = new Point(998, 324);
            ResetBtn.Margin = new Padding(3, 2, 3, 2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(109, 42);
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
            HomeBtn.Location = new Point(998, 386);
            HomeBtn.Margin = new Padding(3, 2, 3, 2);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(109, 42);
            HomeBtn.TabIndex = 46;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 386);
            dataGridView2.Margin = new Padding(2, 1, 2, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(979, 255);
            dataGridView2.TabIndex = 47;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = SystemColors.ActiveCaptionText;
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = SystemColors.ButtonHighlight;
            CrossBtn.Location = new Point(1130, 1);
            CrossBtn.Margin = new Padding(3, 2, 3, 2);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(52, 42);
            CrossBtn.TabIndex = 48;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 150);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 221);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 285);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 23);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 352);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 52;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(591, 154);
            textBox5.Margin = new Padding(2, 1, 2, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 23);
            textBox5.TabIndex = 53;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(591, 338);
            textBox6.Margin = new Padding(2, 1, 2, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 23);
            textBox6.TabIndex = 54;
            // 
            // patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1298, 594);
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
            Margin = new Padding(2, 1, 2, 1);
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