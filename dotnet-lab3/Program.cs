using System.Drawing;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("dotnet-lab3-tests"), InternalsVisibleTo("dotnet-lab3-gui")]
namespace dotnet_lab3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int size = 500;
            MatrixCalc matrixCalc;
            var results = new List<(int threads, int size, long elapsedMs)>();


            //for (int sz = 200; sz < 1000; sz+=100)
            //{
            //    for (int threads = 1; threads <= 14; threads += 2)
            //    {
            //        for (int run = 0; run < 15; run++)
            //        {
            //            matrixCalc = new MatrixCalc(threads, sz);
            //            matrixCalc.SetRandomValues();
            //            var watch = System.Diagnostics.Stopwatch.StartNew();
            //            var ElapsedMs = matrixCalc.MultiplyParallel();
            //            watch.Stop();
            //            //Console.WriteLine($"run {run} took {watch.ElapsedMilliseconds} ms.");
            //            Console.WriteLine($"{threads} {sz} {ElapsedMs}");
            //            results.Add((threads, sz, ElapsedMs));

            //        }
            //    }
            //    using (var writer = new StreamWriter($"results_{sz}.csv"))
            //    {
            //        writer.WriteLine("threads,size,elapsedMs");
            //        foreach (var result in results)
            //        {
            //            writer.WriteLine($"{result.threads},{result.size},{result.elapsedMs}");
            //        }
            //    }
            //}


            //for (int sz = 200; sz < 800; sz += 100)
            //{
            //    for (int threads = 1; threads <= 14; threads += 2)
            //    {
            //        for (int run = 0; run < 15; run++)
            //        {
            //            matrixCalc = new MatrixCalc(threads, sz);
            //            matrixCalc.SetRandomValues();
            //            var watch = System.Diagnostics.Stopwatch.StartNew();
            //            var ElapsedMs = matrixCalc.MultiplyParallel();
            //            watch.Stop();
            //            //Console.WriteLine($"run {run} took {watch.ElapsedMilliseconds} ms.");
            //            Console.WriteLine($"{threads} {sz} {ElapsedMs}");
            //            results.Add((threads, sz, ElapsedMs));

            //        }
            //    }
            //    using (var writer = new StreamWriter($"results_{sz}.csv"))
            //    {
            //        writer.WriteLine("threads,size,elapsedMs");
            //        foreach (var result in results)
            //        {
            //            writer.WriteLine($"{result.threads},{result.size},{result.elapsedMs}");
            //        }
            //    }
            //}







            //matrixCalc.PrintMatrix(matrixCalc.Result);
        }
    }
}
