using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Matrix m = new Matrix();

            double[,] M1 = new double[5, 5];

            if (m.LoadMatrix(M1, "Matrix1.txt"))
                m.PrintMatrix(M1);

            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);


            double[,] M2 = new double[5, 5];

            if (m.LoadMatrix(M2, "Matrix2.txt"))
                m.PrintMatrix(M2);

            Console.WriteLine();

            double[,] ResMatrix = new double[5, 5];
            ResMatrix = MatrixOperations.Multiplication(M1, M2);
            m.PrintMatrix(ResMatrix);

            Console.ReadKey();
        }
    }
}
