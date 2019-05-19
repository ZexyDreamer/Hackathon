using System.Drawing;

namespace Hackaton
{
    public interface IProduct : IItem
    {
        int Count { get; set; }
        Size? Size { get; set; }
        double Sum { get; }
    }
}
