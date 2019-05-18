using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    class Bascket
    {
        public List<Product> Products;

        public Bascket()
        {
            Products = new List<Product>();
        }

        public double Price => Products.Select(p => p.Price).Sum();
    }
}
