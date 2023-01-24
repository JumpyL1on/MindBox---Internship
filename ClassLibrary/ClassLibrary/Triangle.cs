namespace ClassLibrary
{
    public class Triangle : Figure
    {
        private readonly double[] sides;
        public double[] Sides
        {
            get
            {
                return sides;
            }
            init
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }

                if (value[0] >= value[1] + value[2] || value[1] >= value[0] + value[2] || value[2] >= value[0] + value[1])
                {
                    throw new ArgumentException();
                }

                sides = value;
            }
        }

        public bool IsOrthogonal => sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];

        public Triangle(double a, double b, double c)
        {
            Sides = new[] { a, b, c };

            Array.Sort(Sides);
            
            Array.Reverse(Sides);
        }

        public override double CalculateArea()
        {
            var p = Sides.Sum() / 2;

            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }
    }
}