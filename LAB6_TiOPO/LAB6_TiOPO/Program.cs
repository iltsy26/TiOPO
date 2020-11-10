using System;
using System.IO;

namespace LAB6_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"point_output.txt");
            var new_in = new StreamReader(@"point_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Pnts p1 = new Pnts();
            Pnts p2= new Pnts();
            p1.Load();
            p1.Info();

#if !DEBUG
           Console.SetOut(save_out); new_out.Close();
           Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
