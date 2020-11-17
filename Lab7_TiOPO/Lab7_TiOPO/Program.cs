using System;
using System.IO;

namespace Lab7_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"accel_output.txt");
            var new_in = new StreamReader(@"accel_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Acceleration A1, A2;

#if DEBUG
            A2 = new Acceleration(4.5, 4, 2);
            A2.Info(ConsoleColor.Yellow, ConsoleColor.Blue);
#endif

#if !DEBUG  
            A1 = Acceleration.CreateAccelFromFile();
            A1.Info();
#endif

#if !DEBUG
           Console.SetOut(save_out); new_out.Close();
           Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
