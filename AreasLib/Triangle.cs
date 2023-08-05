namespace AreasLib
{
    public class Triangle : IAreable
    {
        public readonly float _a;
        public readonly float _b;
        public readonly float _c;

        public Triangle(float a, float b, float c)
        {
            if(a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Invalid triangle: every side must be less than the sum of the other sides");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            float hypotenuse = _a;
            float leg1 = _b;
            float leg2 = _c;

            if(hypotenuse < leg1)
            {
                float tmp = hypotenuse;
                hypotenuse = leg1;
                leg1 = tmp;
            }
            if (hypotenuse < leg2)
            {
                float tmp = hypotenuse;
                hypotenuse = leg2;
                leg2 = tmp;
            }

            if (Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(leg1, 2) + Math.Pow(leg2, 2))) < 0.0001)
            {
                return leg1 * leg2 / 2;
            }

            double p = (_a + _b + _c) / 2;

            return Math.Sqrt(p*(p - _a)*(p - _b)*(p - _c));
        }
    }
}
