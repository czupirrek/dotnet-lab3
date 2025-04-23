using System.IO;
using System.Security.Cryptography;
using System.Text;
using dotnet_lab3;
using static System.Net.WebRequestMethods;
namespace dotnet_lab3_tests
{
    [DoNotParallelize]
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ResultByParallel()
        {
            string file1 = Path.GetTempFileName();
            string file2 = Path.GetTempFileName();
            MatrixCalc matrixCalc;
            try
            {
                matrixCalc = new MatrixCalc(1, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyParallel();
                using (var writer = new StreamWriter(file1))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }


                matrixCalc = new MatrixCalc(10, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyParallel();
                using (var writer = new StreamWriter(file2))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }

                var hash1 = ComputeMD5(file1);
                var hash2 = ComputeMD5(file2);

                Assert.AreEqual(hash1, hash2, "rozne wyniki parallel single vs. parallel multi");
            }
            finally { 
            if (System.IO.File.Exists(file1)) System.IO.File.Delete(file1);
            if (System.IO.File.Exists(file2)) System.IO.File.Delete(file2);
            }
        }


        [TestMethod]
        public void ResultByThread()
        {
            string file1 = Path.GetTempFileName();
            string file2 = Path.GetTempFileName();

            MatrixCalc matrixCalc;

            try
            {
                matrixCalc = new MatrixCalc(1, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyThread();
                using (var writer = new StreamWriter(file1))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }

                matrixCalc = new MatrixCalc(10, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyThread();
                using (var writer = new StreamWriter(file2))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }

                var hash1 = ComputeMD5(file1);
                var hash2 = ComputeMD5(file2);

                Assert.AreEqual(hash1, hash2, "rozne wyniki thread single vs. thread multi");
            }
            finally
            {
                if (System.IO.File.Exists(file1)) System.IO.File.Delete(file1);
                if (System.IO.File.Exists(file2)) System.IO.File.Delete(file2);
            }


        }

        [TestMethod]
        public void CompareMethods()
        {
            string file1 = Path.GetTempFileName();
            string file2 = Path.GetTempFileName();
            MatrixCalc matrixCalc;

            try
            {
                matrixCalc = new MatrixCalc(1, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyParallel();
                using (var writer = new StreamWriter(file1))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }


                matrixCalc = new MatrixCalc(1, 500, 123456);
                matrixCalc.SetRandomValues();
                matrixCalc.MultiplyThread();
                using (var writer = new StreamWriter(file2))
                {
                    Console.SetOut(writer);
                    matrixCalc.PrintMatrix(matrixCalc.Result);
                }

                var hash1 = ComputeMD5(file1);
                var hash2 = ComputeMD5(file2);

                Assert.AreEqual(hash1, hash2, "rozne wyniki miedzy metodami parallel a thread");
            }
            finally
            {
                if (System.IO.File.Exists(file1)) System.IO.File.Delete(file1);
                if (System.IO.File.Exists(file2)) System.IO.File.Delete(file2);
            }


        }

        private string ComputeMD5(string filePath)
        {
            using (var md5 = MD5.Create())
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }
    }


}
