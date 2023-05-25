namespace Zadaine2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            numericUpDown1 = new NumericUpDown();
            imageList1 = new ImageList(components);
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(2412, 1075);
            numericUpDown1.Margin = new Padding(8);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(367, 184);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 7;
            label1.Text = "Товары магазина \"Магнит\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 319);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 8;
            label2.Text = "Прибыль магазина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 319);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 9;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 349);
            label4.Name = "label4";
            label4.Size = new Size(232, 15);
            label4.TabIndex = 16;
            label4.Text = "Ассортимент магазина обновится через:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 349);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(115, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 239);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 24;
            label6.Text = "  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 242);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 25;
            label7.Text = "кол.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(221, 280);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 27;
            label9.Text = "кол.";
            // 
            // button1
            // 
            button1.Location = new Point(380, 243);
            button1.Name = "button1";
            button1.Size = new Size(123, 31);
            button1.TabIndex = 29;
            button1.Text = "Купить товар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 243);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 34;
            radioButton1.TabStop = true;
            radioButton1.Text = "Молоко";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(22, 281);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 19);
            radioButton2.TabIndex = 35;
            radioButton2.TabStop = true;
            radioButton2.Text = "Мороженое";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(408, 12);
            button2.Name = "button2";
            button2.Size = new Size(171, 28);
            button2.TabIndex = 36;
            button2.Text = "Обновить ассортимент";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 382);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Магазин";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private ImageList imageList1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button2;
    }
}