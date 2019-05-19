using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public static class Bascket
    {
        public static List<Product> Products;

        static Bascket()
        {
            Products = new List<Product>();
        }

        public static double Price => Products.Select(p => p.Price).Sum();
    }
}
