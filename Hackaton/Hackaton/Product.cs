using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hackaton
{
    public class Product
    {
        public Bitmap Image;
        public double Price;
        public double? Count = null;
        public string Name;
        public double? Size = null;
        public string Description;

        public Product(Bitmap Image, double Price, double Count, string Name, 
            double Size, string Description)
        {
            this.Image = Image;
            this.Price = Price;
            this.Count = Count;
            this.Name = Name;
            this.Size = Size;
            this.Description = Description;
        }
    }
}
