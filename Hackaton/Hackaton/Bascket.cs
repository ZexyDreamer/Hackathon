using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    class Bascket
    {
        public List<Product> Products = new List<Product>();

        public Bascket()
        {

        }

        public double GetPrice()
        {
            return Products.Select(p => p.Price).Sum();
        }
    }
}
