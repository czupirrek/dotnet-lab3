namespace dotnet_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 500;
            MatrixCalc matrixCalc = new MatrixCalc(4, size);
            matrixCalc.SetRandomValues();

            //Console.WriteLine("Matrix A:");
            //matrixCalc.PrintMatrix(matrixCalc.A);

            //Console.WriteLine("Matrix B:");
            //matrixCalc.PrintMatrix(matrixCalc.B);

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.WriteLine($"{i} {j} calc");
            //        matrixCalc.MultiplyCell(i, j);
            //    }
            //}



            for (int run = 0; run < 15; run++)
            {
                matrixCalc = new MatrixCalc(4, size);

                matrixCalc.SetRandomValues();

                ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = 16 };
                int[] ThreadsUsed = new int[30];
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Parallel.For(0, size, opt, x =>
                {
                    for (int i = 0; i < size; i++)
                    {
                        matrixCalc.MultiplyCell(x, i);
                    }
                    ThreadsUsed[Thread.CurrentThread.ManagedThreadId]++;
                });
                watch.Stop();
                //Console.WriteLine($"run {run} took {watch.ElapsedMilliseconds} ms.");
                Console.WriteLine($"{watch.ElapsedMilliseconds}");


            }


            //matrixCalc.PrintMatrix(matrixCalc.Result);
        }
    }
}
