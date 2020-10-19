using System;
using System.IO;

namespace Lab4_TiOPO
{
    class Testing
    {
        public static Boolean CheckMass(int N, double[] mas)
        {
            bool check = true;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(mas[i]) > 100000)
                    check = false;
            }
            return check;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string No = "No";
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input1.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            double[] mas = new double[N];
            for(int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToDouble(str_elem[i]);
            }

#if DEBUG
                if (!Testing.CheckMass(N, mas))
                    Console.WriteLine("Test \'CheckMass\' Failed!!!");
#endif

            double maxUnd0 = -100000;
            double minOvr0 = 100000;
            for (int i = 0; i < N; i++)
            {
                if ((mas[i] < 0) && (mas[i] > maxUnd0))
                {
                    maxUnd0 = mas[i];
                }

                if ((mas[i] > 0) && (mas[i] < minOvr0))
                {
                    minOvr0 = mas[i];
                }
            }

            if (maxUnd0 != -100000)
            {
                Console.WriteLine(string.Format("max elem under 0 = {0:0.000000}", maxUnd0));
            }
            else
            {
                Console.WriteLine("max elem under 0 = " + No);
            }

            if (minOvr0 != 0)
            {
                Console.WriteLine(string.Format("min elem over 0 = {0:0.000000}", minOvr0));
            }
            else
            {
                Console.WriteLine ("min elem over 0 = " + No);
            }

            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(mas[i]) > 10000)
                    Console.Write(mas[i] + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
