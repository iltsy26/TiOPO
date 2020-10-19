using System;
using System.IO;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            String FileName;

            Console.Write("Inter N > ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inter file name (without txt) > ");
            FileName = Console.ReadLine();
            FileName += ".txt";

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(FileName);
            Console.SetOut(new_out);

            Console.WriteLine(N);

            Random r = new Random(DateTime.Now.Millisecond);
            double x = 0;
            for (int i = 0; i < N; i++)
            {
                x = r.Next(1000);
                Console.Write(x + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("File " + FileName + " was created!!!");
            Console.ReadKey();
        }
    }
}
