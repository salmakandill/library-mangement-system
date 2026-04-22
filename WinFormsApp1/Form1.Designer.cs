namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button5 = new Button();
            button10 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(228, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 564);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1013, 211);
            dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(250, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   enter student Id";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(381, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "    enter student Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 4;
            label1.Text = "Student Registration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(126, 55);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 4;
            label2.Text = "Student ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(685, 261);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 261);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(140, 203);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 7;
            label5.Text = "Level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(126, 157);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(126, 106);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 5;
            label3.Text = "Student Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ControlDarkDark;
            textBox2.Location = new Point(250, 106);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "   enter student name";
            textBox2.Size = new Size(381, 24);
            textBox2.TabIndex = 1;
            textBox2.Text = "   enter student name";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.WindowFrame;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(250, 202);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(381, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "    enter student level";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(250, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "   enter student department";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(79, 109, 131);
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 670);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(79, 109, 131);
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Image = Properties.Resources.icons8_home_16__1_;
            button6.Location = new Point(26, 123);
            button6.Name = "button6";
            button6.Size = new Size(103, 44);
            button6.TabIndex = 9;
            button6.Text = "    Home";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(79, 109, 131);
            button7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = Properties.Resources.icons8_check_16;
            button7.Location = new Point(26, 173);
            button7.Name = "button7";
            button7.Size = new Size(114, 27);
            button7.TabIndex = 10;
            button7.Text = "  Attendance";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(79, 109, 131);
            button8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Image = Properties.Resources.icons8_books_16;
            button8.Location = new Point(29, 216);
            button8.Name = "button8";
            button8.Size = new Size(100, 29);
            button8.TabIndex = 9;
            button8.Text = "  Archive";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(79, 109, 131);
            button9.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Image = Properties.Resources.icons8_user_male_16;
            button9.Location = new Point(29, 252);
            button9.Name = "button9";
            button9.Size = new Size(100, 30);
            button9.TabIndex = 9;
            button9.Text = "  profile";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(219, 12);
            button5.Name = "button5";
            button5.Size = new Size(243, 46);
            button5.TabIndex = 11;
            button5.Text = "Welcome Admin";
            button5.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(231, 54);
            button10.Name = "button10";
            button10.Size = new Size(231, 25);
            button10.TabIndex = 11;
            button10.Text = " manage Students  , Attendance ";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(29, 297);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 12;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            BackgroundImage = Properties.Resources.photo_5999234508768611443_y1;
            ClientSize = new Size(1253, 613);
            Controls.Add(button3);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AdminPadge";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button5;
        private Button button10;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}
