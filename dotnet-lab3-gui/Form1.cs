using dotnet_lab3;
namespace dotnet_lab3_gui
{
    public partial class Form1 : Form
    {
        bool MatrixSizeError = false;
        bool RNGSeedError = false;
        bool NThreadsError = false;

        bool methodParallelSelected = true;
        bool methodThreadSelected = false;

        int threads = 1;
        int matrixSize = 2;
        int RNGSeed = 0;
        MatrixCalc matrixCalc;
        public Form1()
        {
            InitializeComponent();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                numericUpDown1.BackColor = Color.Red;
                MatrixSizeError = true;
            }
            else
            {
                numericUpDown1.BackColor = Color.White;
                MatrixSizeError = false;
                matrixSize = (int)numericUpDown1.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 0)
            {
                numericUpDown2.BackColor = Color.Red;
                RNGSeedError = true;
            }
            else
            {
                numericUpDown2.BackColor = Color.White;
                RNGSeedError = false;
                RNGSeed = (int)numericUpDown2.Value;

            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value <= 0)
            {
                numericUpDown3.BackColor = Color.Red;
                NThreadsError = true;
            }
            else
            {
                numericUpDown3.BackColor = Color.White;
                NThreadsError = false;
                threads = (int)numericUpDown3.Value;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            methodParallelSelected = true;
            methodThreadSelected = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            methodThreadSelected = true;
            methodParallelSelected = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MatrixSizeError)
            {
                textBox1.Text = "rozmiar macierzy musi byc wiekszy od 0";
                return;
            }

            if (RNGSeedError)
            {
                textBox1.Text = "seed musi byc wiekszy od 0";
                return;
            }
            if (NThreadsError)
            {
                textBox1.Text = "ilosc watkow musi byc wieksza od 0";
                return;
            }

            if (RNGSeed == 0)
            {
                RNGSeed = DateTime.Now.Millisecond;
            }



            if (methodParallelSelected)
            {
                matrixCalc = new MatrixCalc(threads, matrixSize, RNGSeed);
                matrixCalc.SetRandomValues();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var ElapsedMs = matrixCalc.MultiplyParallel();
                watch.Stop();
                textBox1.Text = $"took: {watch.ElapsedMilliseconds} ms.\r\nmethod parallel \r\n{threads} threads\r\n{matrixSize} size\r\n{RNGSeed} seed";
            }
            else if (methodThreadSelected)
            {
                matrixCalc = new MatrixCalc(threads, matrixSize, RNGSeed);
                matrixCalc.SetRandomValues();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var ElapsedMs = matrixCalc.MultiplyThread();
                watch.Stop();
                textBox1.Text = $"took: {watch.ElapsedMilliseconds} ms.\r\nmethod thread\r\n{threads} threads\r\n{matrixSize} size\r\n{RNGSeed} seed";

            }




            dataGridView1.ColumnCount = matrixSize;
            dataGridView1.RowCount = matrixSize;
            dataGridView1.RowHeadersVisible = false;

            for (int i = 0; i < matrixSize; i++)
            {
                dataGridView1.Columns[i].Width = 40; 
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    dataGridView1.Rows[row].Cells[col].Value = matrixCalc.Result[row, col];
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RNGSeed = DateTime.Now.Millisecond;
            numericUpDown2.BackColor = Color.White;
            RNGSeedError = false;
            numericUpDown2.Value = RNGSeed;
        }
    }
}
