using System.Collections.Generic;
using System.Net.Mime;
using System.Drawing;

namespace Hackaton
{
    public class Category
    {
        public Bitmap Image;
        public string Name;
        public List<IItem> ListProducts;

        public Category(Bitmap image, string name)
        {
            Image = image;
            Name = name;
            ListProducts = new List<IItem>();
        }
    }
}