

using Task_02.Interfaces;

namespace Task_02
{
    public class Circle : IShape
    {
        private double radius;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
