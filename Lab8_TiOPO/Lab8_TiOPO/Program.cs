using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Mnogougolnik> allMn = new List<Mnogougolnik>();
			allMn.Add(new Treugolnik("Треугольник 1", "Blue", 2.0, 3.4, 5.1));
			allMn.Add(new PryamParallelepiped("Прямоуголный параллелепипед 1", "Yellow", 6.0, 4.5, 2.005));

			List<Ellips> allEllips = new List<Ellips>();
			allEllips.Add(new Ellips("Эллипс 1", "Violet", 6.0, 2.5));
			allEllips.Add(new Ellips("Эллипс 2", "Green", 1.1, 1.1));
			allEllips.Add(new Ellips("Эллипс 3", "Silver", 5.0, 8.3));

			List<Geometria> allFig = new List<Geometria>();
			allFig.Add(new Ellips("Эллипс 1", "Violet", 6.0, 2.5));
	

			Console.WriteLine("В данной работе может быть выведено пустое поле если для фигуры не определен соответствующий метод");
			Console.WriteLine();
			Console.WriteLine("Вывод всех многоугольников");
			Console.WriteLine();
			for (int i = 0; i < allMn.Count(); i++)
			{
				Console.WriteLine(allMn[i].getFigData());
				Console.WriteLine("Периметр фигуры: ");
				Console.WriteLine(allMn[i].Mnogougolnik_P());
				Console.WriteLine("Объем фигуры фигуры: ");
				Console.WriteLine(allMn[i].Mnogougolnik_V());
				Console.WriteLine();
			}

			Console.WriteLine("Вывод всех эллипсов");
			Console.WriteLine();
			for (int i = 0; i < allEllips.Count(); i++)
			{
				Console.WriteLine(allEllips[i].getFigData());
				Console.WriteLine("Периметр фигуры: ");
				Console.WriteLine(allEllips[i].Ellipe_P());
				Console.WriteLine("Площадь фигуры: ");
				Console.WriteLine(allEllips[i].Ellipe_S());
				Console.WriteLine();
			}

			Console.WriteLine("Вывод имен фигур");
			Console.WriteLine();
			for (int i = 0; i < allFig.Count() ; i++)
			{
				Console.WriteLine(allFig[i].getName());
				Console.WriteLine();
			}

			Console.ReadKey();
		}
    }
}
