using System.Threading;

namespace dotnet_lab3_images
{
    public partial class Form1 : Form
    {
        private Bitmap? src;
        bool ready = false;
        public Form1()

        {
            InitializeComponent();
        }



        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                src = new Bitmap(file);
                pictureBox5.Image = src;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                ready = true;

            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;




        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ready)
            {
                MessageBox.Show("nie ma obrazka!");
                return;
            }
            ImageTransform imageTransform = new ImageTransform(src);
            Thread[] threads = new Thread[6];
            threads[0] = new Thread(() => { pictureBox1.Image = new ImageTransform(src).Rotate(90); });
            threads[1] = new Thread(() => { pictureBox2.Image = new ImageTransform(src).Invert(); });
            threads[2] = new Thread(() => { pictureBox3.Image = new ImageTransform(src).Threshold(120); });
            threads[3] = new Thread(() => { pictureBox4.Image = new ImageTransform(src).Greyscale(); });
            threads[4] = new Thread(() => { pictureBox6.Image = new ImageTransform(src).ChannelSwap(); });
            threads[5] = new Thread(() => { pictureBox7.Image = new ImageTransform(src).ChannelThreshold(120); });

            foreach (Thread t in threads) t.Start();
            foreach (Thread t in threads) t.Join();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
