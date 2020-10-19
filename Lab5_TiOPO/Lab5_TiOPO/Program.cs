using System;
using System.IO;

namespace Lab5_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"inp2.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Input matrix ***");

            double[,] mas = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            //double[] SumSt = new double[M];
            double[] saSt = new double[M];

            Console.WriteLine("*** Average for each column ***");
            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    saSt[j] += mas[i, j];
                }
                saSt[j] = saSt[j] / M;
                Console.Write("Avrg for column " + (j+1) + " ");
                Console.Write(string.Format(" {0:0.000}", saSt[j]));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("*** Modifed matrix ***");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] >= saSt[j])
                        Console.Write("L  ");
                    else
                        Console.Write("m  ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
