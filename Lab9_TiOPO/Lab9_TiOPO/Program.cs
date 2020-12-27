using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
			List<IDrawable> allFig = new List<IDrawable>();
			allFig.Add(new Treugolnik("Треугольник 1", "Blue", 2.0, 3.4, 5.1));
			allFig.Add(new PryamParallelepiped("Прямоуголный параллелепипед 1", "Yellow", 6.0, 4.5, 2.005));
			allFig.Add(new PryamParallelepiped("Прямоуголный параллелепипед 2", "Red", 2.0, 0.7, 0.5));
			allFig.Add(new Ellips("Эллипс 1", "Brown", 2.0, 3.5));

			for (int i = 0; i < allFig.Count; i++)
			{
				Console.WriteLine(allFig[i].Str());
				Console.WriteLine();
				allFig[i].Draw();
				Console.WriteLine();
			}

			Console.ReadKey();
		}
    }
}
