using System.Drawing;

namespace Hackaton
{
    public interface IItem
    {
        Bitmap Image { get; set; }
        double Price { get; set; }
        int Count { get; set; }
        string Name { get; set; }
        double? Size { get; set; }
        double Sum { get; }
    }
}
