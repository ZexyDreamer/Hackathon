﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public static class Bascket
    {
<<<<<<< HEAD
        public static List<Product> Products;
=======
        public List<IItem> Products;
>>>>>>> Valera

        static Bascket()
        {
<<<<<<< HEAD
            Products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var p = new Product(
                    new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\Gazon.jpeg"),
                    100,
                    10,
                    "Газон",
                    null,
                    "газон обыкновенный");
                Products.Add(p);
            }
=======
            Products = new List<IItem>();
>>>>>>> Valera
        }

        public static double Price => Products.Select(p => p.Price).Sum();
    }
}
