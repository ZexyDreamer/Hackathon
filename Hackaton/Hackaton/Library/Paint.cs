using System.Drawing;

namespace Hackaton
{
    public class Paint : IProduct
    {
        public Bitmap Image { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double? Size { get; set; }
        public double Sum { get; }
        
        public Paint(Bitmap image, double price, string name, double sum, double size = 0, int count = 1)
        {
            Image = image;
            Price = price;
            Name = name;
            Size = size;
            Count = count;
        }
    }
}