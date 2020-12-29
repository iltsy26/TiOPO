using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab11_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_20.csv");
#if !DEBUG
            TextWriter save_out = Console.out;
            var new_out = new StreamWriter(@"lr11_output.txt");
            Console.SetOut(new_out);
#endif
            List<Item> all = new List<Item>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Item.Create(line));
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Всего товаров: {0}", all.Count);
            /*foreach (var p in all)
                Console.WriteLine(p);*/

            Console.WriteLine("\n****** Задача 1 ******");
            float MicrosoftP = (from p in all
                              where p.Company == "Microsoft"
                              select p.Count * p.Price).Sum();
            Console.WriteLine("Объем в валюте для Microsoft: {0}", MicrosoftP);

            float CraftLtdP = (from p in all
                                where p.Company == "Craft Ltd"
                               select p.Count * p.Price).Sum();
            Console.WriteLine("Объем в валюте для Craft Ltd: {0}", CraftLtdP);

            float MKSP = (from p in all
                                where p.Company == "MKS"
                          select p.Count * p.Price).Sum();
            Console.WriteLine("Объем в валюте для MKS: {0}", MKSP);

            float NestleP = (from p in all
                               where p.Company == "Nestle"
                             select p.Count * p.Price).Sum();
            Console.WriteLine("Объем в валюте для Nestle: {0}", NestleP);

            Console.WriteLine("\n****** Задача 2 ******");
            int mCount = all.FindAll(p => p.Price < 15.00).ToList().Count;
            Console.WriteLine("Количество наименований товаров дешевле $15,00 : {0}", mCount);

            Console.WriteLine("\n****** Задача 3 ******");
            float total_OofD_price = (from p in all
                                      where (p.OutOfDate == true)
                                      select p.Price * p.Count).Sum();
            float OofD_Microsoft = (from p in all
                                    where p.OutOfDate == true && p.Company == "Microsoft"
                                    select p.Price * p.Count).Sum();
            float OofD_CraftLtd = (from p in all
                                   where (p.OutOfDate == true) && p.Company == "Craft Ltd"
                                   select p.Price * p.Count).Sum();
            float OofD_MKS = (from p in all
                              where (p.OutOfDate == true) && p.Company == "MKS"
                              select p.Price * p.Count).Sum();
            float OofD_Nestle = (from p in all
                                 where (p.OutOfDate == true) && p.Company == "Nestle"
                                 select p.Price * p.Count).Sum();
            var f = System.Globalization.CultureInfo.GetCultureInfo("en-us");
            Console.WriteLine("Суммарный объем просрочки: {0}\n" + "Microsoft: {1},\t Craft Ltd: {2},\n" + "MKS: {3}\t, Nestle: {4}",
                total_OofD_price.ToString("C3", f),
                OofD_Microsoft.ToString("C", f), OofD_CraftLtd.ToString("C", f),
               OofD_MKS.ToString("C", f), OofD_Nestle.ToString("C", f));

            Console.WriteLine("\n****** Задача 4 ******");
            float pCount = (from p in all
                             where p.Price > 50.0
                             select p.Count).Sum();
            Console.WriteLine("Количество товаров с ценой более $50,00 : {0}", pCount);

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
