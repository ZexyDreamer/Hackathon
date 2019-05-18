using System.Drawing;

namespace Hackaton
{
    public interface IProduct : IItem
    {
        Bitmap Image { get; set; }
        int Count { get; set; }
        double? Size { get; set; }
        double Sum { get; }
    }
}
