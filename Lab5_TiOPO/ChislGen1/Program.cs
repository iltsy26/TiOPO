using System;
using System.IO;

namespace ChislGen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            String FileName;

            Console.Write("Inter N > ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inter M > ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inter file name (without txt) > ");
            FileName = Console.ReadLine();
            FileName += ".txt";

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(FileName);
            Console.SetOut(new_out);

            Console.WriteLine(N);
            Console.WriteLine(M);

            Random r = new Random(DateTime.Now.Millisecond);
            double x = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    x = r.Next(1000);
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("File " + FileName + " was created!!!");
            Console.ReadKey();
        }
    }
}
