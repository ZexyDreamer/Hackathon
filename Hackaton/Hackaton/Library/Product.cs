using System.Drawing;

namespace Hackaton
{
    public class Product : IItem
    {
        public Bitmap Image { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double? Size { get; set; }
        public double Sum => Price * Count;
        
        public Product(Bitmap image, double price, int count, string name, double size)
        {
            Image = image;
            Price = price;
            Count = count;
            Name = name;
            Size = size;
        }
    }
}