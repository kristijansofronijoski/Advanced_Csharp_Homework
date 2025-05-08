

namespace Task_03
{
    public class Triangle : Shape
    {
        private int v1;
        private int v2;
        private int v3;

        public Triangle(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override double CalculateArea()
        {
            double s = (v1 + v2 + v3) / 2;

         
            return Math.Sqrt(s * (s - v1) * (s - v2) * (s - v3));
        }

        public override double CalculatePerimeter()
        {
            return v1 + v2 + v3;
        }
    }
}
