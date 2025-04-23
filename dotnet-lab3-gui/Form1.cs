namespace dotnet_lab3_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Przyk³adowa tablica
            int[,] macierz = new int[10, 10];

            // Wype³nij czymœ testowo
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    macierz[i, j] = i * 10 + j; // lub cokolwiek innego


            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
            dataGridView1.RowHeadersVisible = false;

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Columns[i].Width = 40; // Dopasuj szerokoœæ kolumn
            }

            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    dataGridView1.Rows[row].Cells[col].Value = macierz[row, col];
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
