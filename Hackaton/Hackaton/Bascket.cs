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
        public static List<IProduct> Products;

        static Bascket()
        {
            Products = new List<IProduct>();
            for (int i = 0; i < 10; i++)
            {
                var p = new Grass(
                    new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\Gazon.jpeg"),
                    100,     
                    "Газон",
                    10);
                p.Description = "Газон обыкновенный";
                Products.Add(p);
            }
        }

        public static double Price => Products.Select(p => p.Sum).Sum();
    }
}
