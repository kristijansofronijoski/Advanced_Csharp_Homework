
using Task_02.Interfaces;

namespace Task_02
{
    public  class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
    }
}
