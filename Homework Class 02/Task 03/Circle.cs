
namespace Task_03
{
    public class Circle : Shape
    {
        private int v;

        public Circle(int v)
        {
            this.v = v;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(v, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * v;
        }
    }
}
