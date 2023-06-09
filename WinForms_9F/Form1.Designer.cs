namespace WinForms_9F
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            button4 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 38);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 103);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 1;
            label2.Text = "Vəzifə:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 163);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(81, 32);
            label3.TabIndex = 2;
            label3.Text = "Maaş:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 39);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(449, 287);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(891, 38);
            button1.Name = "button1";
            button1.Size = new Size(312, 52);
            button1.TabIndex = 7;
            button1.Text = "Əlavə et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(891, 100);
            button2.Name = "button2";
            button2.Size = new Size(312, 52);
            button2.TabIndex = 8;
            button2.Text = "Göstər";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(891, 163);
            button3.Name = "button3";
            button3.Size = new Size(312, 52);
            button3.TabIndex = 9;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(717, 428);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 39);
            textBox4.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(1010, 420);
            button4.Name = "button4";
            button4.Size = new Size(125, 47);
            button4.TabIndex = 11;
            button4.Text = "Axtar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(717, 372);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(125, 32);
            label4.TabIndex = 12;
            label4.Text = "İşçi axtar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1283, 640);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Button button4;
        private Label label4;
    }
}