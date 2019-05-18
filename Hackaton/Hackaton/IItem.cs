namespace Hackaton
{
    public interface IItem
    {
        public Bitmap Image;
        public double Price;
        public double? Count = null;
        public string Name;
        public double? Size = null;
        public double GetSum(double price, double count, double size = 0);
    }
}
