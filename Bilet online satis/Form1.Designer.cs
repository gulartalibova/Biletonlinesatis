namespace Bilet_online_satis
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
            button2 = new Button();
            comboBox3 = new ComboBox();
            label9 = new Label();
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
            textBox2 = new TextBox();
            label8 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marsurut";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(210, 156);
            label11.Name = "label11";
            label11.Size = new Size(82, 26);
            label11.TabIndex = 11;
            label11.Text = "label11";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 153);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 10;
            button2.Text = "deyisdir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(174, 336);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(226, 34);
            comboBox3.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 342);
            label9.Name = "label9";
            label9.Size = new Size(76, 26);
            label9.TabIndex = 8;
            label9.Text = "Yerler:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(174, 270);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(226, 34);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 278);
            label4.Name = "label4";
            label4.Size = new Size(63, 26);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 34);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 210);
            label3.Name = "label3";
            label3.Size = new Size(68, 26);
            label3.TabIndex = 4;
            label3.Text = "Tarix:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baki", "Gence", "Kurdemir", "Qazax", "Samaxi", "Istanbul", "Tibilisi" });
            comboBox2.Location = new Point(175, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 34);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Gence", "Kurdemir", "Qazax", "Samaxi", "Istanbul", "Tibilisi" });
            comboBox1.Location = new Point(174, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 34);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 1;
            label2.Text = "Haraya:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 26);
            label1.TabIndex = 0;
            label1.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(580, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 405);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sernisin bilgileri";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(173, 333);
            button1.Name = "button1";
            button1.Size = new Size(237, 55);
            button1.TabIndex = 9;
            button1.Text = "Bilet al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 34);
            textBox2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 236);
            label8.Name = "label8";
            label8.Size = new Size(133, 26);
            label8.TabIndex = 7;
            label8.Text = "Email adres:";
            label8.Click += label8_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(236, 168);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(208, 34);
            maskedTextBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 176);
            label7.Name = "label7";
            label7.Size = new Size(168, 26);
            label7.TabIndex = 5;
            label7.Text = "Telefon nomresi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 34);
            textBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(236, 108);
            maskedTextBox2.Mask = "00000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(208, 34);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 56);
            label6.Name = "label6";
            label6.Size = new Size(135, 26);
            label6.TabIndex = 2;
            label6.Text = "Ad ve Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 116);
            label5.Name = "label5";
            label5.Size = new Size(184, 26);
            label5.TabIndex = 1;
            label5.Text = "Sexsiyyet nomresi:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(57, 558);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(994, 160);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label10);
            panel1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(57, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 115);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(696, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Vivaldi", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(59, 26);
            label10.Name = "label10";
            label10.Size = new Size(412, 71);
            label10.TabIndex = 0;
            label10.Text = "LALE   travel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1200, 755);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Label label5;
        private Label label8;
        private MaskedTextBox maskedTextBox3;
        private Label label7;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private TextBox textBox2;
        private ListBox listBox1;
        private ComboBox comboBox3;
        private Label label9;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label10;
        private Button button2;
        private Label label11;
    }
}
