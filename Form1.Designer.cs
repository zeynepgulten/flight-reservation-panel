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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            listBox1 = new ListBox();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(324, 54);
            label11.Name = "label11";
            label11.Size = new Size(106, 23);
            label11.TabIndex = 10;
            label11.Text = "Nereden:";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonShadow;
            label10.Location = new Point(324, 47);
            label10.Name = "label10";
            label10.Size = new Size(0, 23);
            label10.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(324, 47);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(324, 94);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(150, 203);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 34);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 206);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 34);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 150);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            label3.Click += label3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SİNOP", "ANKARA", "İSTANBUL ", "İZMİR", "AYDIN ", "ESKİŞEHİR", "MALATYA", "KOCAELİ ", "TRABZON ", "KONYA" });
            comboBox2.Location = new Point(150, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SİNOP", "ANKARA", "İSTANBUL ", "İZMİR", "AYDIN ", "ESKİŞEHİR", "MALATYA", "KOCAELİ ", "TRABZON ", "KONYA" });
            comboBox1.Location = new Point(150, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 102);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 54);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(637, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 319);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(157, 222);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 8;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 165);
            label7.Name = "label7";
            label7.Size = new Size(46, 23);
            label7.TabIndex = 7;
            label7.Text = "No:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 105);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 6;
            label6.Text = "TC:";
            label6.Click += label6_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(157, 162);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(181, 34);
            maskedTextBox3.TabIndex = 5;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(157, 102);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 34);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 34);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 51);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 0;
            label5.Text = "Ad-soyad:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 62);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(651, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(412, 9);
            label8.Name = "label8";
            label8.Size = new Size(219, 34);
            label8.TabIndex = 1;
            label8.Text = "HAVA YOLLARI";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(57, 434);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(995, 119);
            listBox1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 571);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 35);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 601);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("SimSun", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private Panel panel2;
        private Button button2;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}
