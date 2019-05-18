using System.Drawing;

namespace Hackaton
{
    public class Service : IService
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Bitmap Image { get; set; }
        public double Price { get; set; }
        
        public Service(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}