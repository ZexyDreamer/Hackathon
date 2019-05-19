using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Hackaton
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        ///
        public static List<Product> list = new List<Product>()
        {
            new Product(new Bitmap(@"../../Images/Bench.jpg"), 1000, 0, "Скамейка", new Size(), "Скамейка Обычная", Categories.Other),
            new Product(new Bitmap(@"../../Images/Cement.jpg"), 1000, 0, "Цемент", new Size(), "Цемент Обычный", Categories.BuildingMaterials),
            new Product(new Bitmap(@"../../Images/Concrete.jpeg"), 1000, 0, "Бетон", new Size(), "Бетон Обычный", Categories.BuildingMaterials),
            new Product(new Bitmap(@"../../Images/Detskaya_ploshadka.jpg"), 1000, 0, "Детская площадка", new Size(), "Детская площадка", Categories.Other),
            new Product(new Bitmap(@"../../Images/Gazon.jpeg"), 1000, 0, "Газон площадка", new Size(), "Газон площадка", Categories.Other),
            new Product(new Bitmap(@"../../Images/Grill.jpeg"), 1000, 0, "Гриль", new Size(), "Гриль Обычный", Categories.Other),
        };

        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }

}
