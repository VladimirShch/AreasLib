namespace AreasLib
{
    public class Circle : IAreable
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Circle radius must be a positive number");
            }

            _radius = radius;
        }

        public double GetArea()
        {
            return 2 * Math.PI * Math.Pow(_radius, 2);
        }
    }
}