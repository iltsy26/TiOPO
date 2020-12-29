using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_TiOPO
{
    class Item
    {
        internal String ID { get; set; }
        internal String Product { get; set; }
        internal String Company { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public Boolean OutOfDate { get; set; }

        public static Item Create(String str)
        {
            Item p = new Item();

            if (str.Contains("\""))
            {
                int a = str.IndexOf("\"");
                int b = str.LastIndexOf("\"");
                string c = str.Substring(a, b - a + 1);
                str = str.Replace(c, "X");
                string[] e = str.Split(',');
                p.ID = e[0].Trim();
                p.Product = c;
                p.Company = e[2].Trim();
                p.Price = Convert.ToSingle(e[3].TrimStart('$').Replace('.', ','));
                p.Count = Convert.ToInt32(e[4].Trim());
                p.OutOfDate = Convert.ToBoolean(e[5].Trim());
            }
            else
            {
                string[] e = str.Split(',');
                p.ID = e[0].Trim();
                p.Product = e[1].Trim();
                p.Company = e[2].Trim();
                p.Price = Convert.ToSingle(e[3].TrimStart('$').Replace('.', ','));
                p.Count = Convert.ToInt32(e[4].Trim());
                p.OutOfDate = Convert.ToBoolean(e[5].Trim());
            }
            return p;
        }

        public override string ToString()
        {
            String s = string.Format(
                "***********************************\n" +
                "ID: {0}, Имя товара: {1}, Поставщик: {2}, Цена: {3}\n" +
                "Количество товаров: {4}, Просрочка: {5}",
                ID, Product, Company, Price, Count, OutOfDateToStr(OutOfDate));

            return s;
        }
        private static String OutOfDateToStr(Boolean g)
        {
            if (g == true) return "Да";
            else return "Нет";   
        }
    }
}
