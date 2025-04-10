using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_lab3
{
    class MatrixCalc
    {
        public int[,] A { get; set; }
        public int[,] B { get; set; }
        public int[,] Result { get; set; }
        int NThreads = 1;
        int RngSeed = 0;
        Random rand;
        int MinCellValue = 0;
        int MaxCellValue = 1000;
        public MatrixCalc(int NThreads, int MatrixSize)
        {
            this.NThreads = NThreads;
            RngSeed = DateTime.Now.Millisecond;
            this.rand = new Random(RngSeed);

            A = new int[MatrixSize, MatrixSize];
            B = new int[MatrixSize, MatrixSize];
            Result = new int[A.GetLength(0), B.GetLength(1)];
        }

        public void SetRandomValues()
        {
            for (int m = 0; m < 2; m++)
            {
                int[,] Matrix = m == 0 ? A : B;
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Matrix[i, j] = rand.Next(MinCellValue, MaxCellValue + 1);
                    }
                }
            }
        }

        public void MultiplyCell(int n, int m)
        {
            int Sum = 0;
            for (int i = 0; i < A.GetLength(1); i++) 
            {
                Sum += A[n, i] * B[i, m];
            }
            Result[n, m] = Sum; 
        }


        public void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
