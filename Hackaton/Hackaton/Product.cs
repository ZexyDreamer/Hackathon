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
        public double OnePrice;
        public double? Count = null;
        public string Name;
        public Size? Size = null;
        public string Description;

        public Product(Bitmap Image, double OnePrice, double? Count, string Name,
            Size? Size, string Description)
        {
            this.Image = Image;
            this.OnePrice = OnePrice;
            this.Count = Count;
            this.Name = Name;
            this.Size = Size;
            this.Description = Description;
        }

        public double Price =>
            Count is null
            ? OnePrice * Size.Value.Height * Size.Value.Width
            : OnePrice * Count.Value;
    }
}
