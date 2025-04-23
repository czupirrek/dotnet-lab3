namespace dotnet_lab3_images
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(599, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(404, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 165);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(599, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 165);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(404, 212);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(189, 165);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(386, 336);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Images (*.jpg)|*.jpg";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 354);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 5;
            button1.Text = "Wczytaj obraz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(794, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(189, 165);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(794, 212);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(189, 165);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 180);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "negatyw";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 180);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "obrót";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(838, 180);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "zamiana kanałów";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 380);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "szarość";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(635, 380);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 12;
            label5.Text = "progowanie szarości";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(838, 380);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 13;
            label6.Text = "progowanie kolorów";
            // 
            // button2
            // 
            button2.Location = new Point(251, 354);
            button2.Name = "button2";
            button2.Size = new Size(147, 23);
            button2.TabIndex = 14;
            button2.Text = "Przetwarzanie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}
