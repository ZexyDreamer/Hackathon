using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public class Bascket
    {
        public List<IItem> Products;

        public Bascket()
        {
            Products = new List<IItem>();
        }

        public double Price => Products.Select(p => p.Price).Sum();
    }
}
