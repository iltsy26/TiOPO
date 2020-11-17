using System;

namespace Lab7_TiOPO
{
    class Acceleration
    {
        private double StartSpeed, accel;
        private int time;

        private Acceleration() { }

        public Acceleration(double Nspeed, double Naccel, int Ntime )
        {
            StartSpeed = Nspeed; accel = Naccel; time = Ntime;
        }

        private void Load()
        {
            StartSpeed = Convert.ToDouble(Console.ReadLine());
            accel = Convert.ToDouble(Console.ReadLine());
            time = Convert.ToInt32(Console.ReadLine());
        }

        public static Acceleration CreateAccelFromFile()
        {
            double Spd = Convert.ToDouble(Console.ReadLine());
            double Accl = Convert.ToDouble(Console.ReadLine());
            int Time = Convert.ToInt32(Console.ReadLine());
            return new Acceleration (Spd, Accl, Time);
        }

        public double Distance()
        {
            return StartSpeed * time + (accel * Math.Pow(time, 2)) / 2;
        }

        public double CurrentSpeed()
        {
            return StartSpeed + accel * time;
        }

        public void Info()
        {
            String str = "\n--------------------------\n" +
                         "\n Равноускоренное движение\n" +
                        "\n--------------------------\n";

            Console.WriteLine(str);
            Console.WriteLine(String.Format("Initial Speed = {0:0.00}", StartSpeed));
            Console.WriteLine(String.Format("Acceleration = {0:0.00}", accel));
            Console.WriteLine(String.Format("Time = {0:0.00}", time));
            Console.Write(String.Format("Distance({0:0.00}", time));
            Console.WriteLine(String.Format(") = {0:0.00}", Distance()));
            Console.Write(String.Format("Speed({0:0.00}", time));
            Console.WriteLine(String.Format(") = {0:0.00}", CurrentSpeed()));

        }
        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
        }
    }
}
