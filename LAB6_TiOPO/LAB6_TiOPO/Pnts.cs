using System;
using System.IO;

namespace LAB6_TiOPO
{
    class Pnts
    { 
        private double x1, y1, x2, y2;

        public double DistanceToOrigin(double x, double y) { return Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)); }

        public double DistanceBetweenPoints(double x1, double y1, double x2, double y2) { return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); }
        
        public void Info()
        {
            Console.Write(string.Format("X1 = {0:0.00}, ", x1));
            Console.WriteLine(string.Format("Y1 = {0:0.00}", y1));
            Console.Write(string.Format("X2 = {0:0.00}, ", x2));
            Console.WriteLine(string.Format("Y2 = {0:0.00}", y2));
            Console.WriteLine(string.Format("Расстояние от первой точки до начала координат = {0:0.00}", DistanceToOrigin(x1, y1)));
            Console.WriteLine(string.Format("Расстояние от второй точки до начала координат = {0:0.00}", DistanceToOrigin(x2, y2)));
            Console.WriteLine(string.Format("Расстояние между точками = {0:0.00}", DistanceBetweenPoints(x1, y1, x2, y2)));
        }

        public void Load()
        {
            Console.WriteLine("Введите координаты первой точки (x1, y1): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки (x2, y2): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
