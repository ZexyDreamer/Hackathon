using System.Drawing;

namespace Hackaton
{
    public interface IItem
    {
        string Name { get; set; }
        double Price { get; set; }
        string Description { get; set; }
        Bitmap Image { get; set; }
    }
}