namespace ClassLibrary
{
    public class Circle : Figure
    {
        private readonly double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}