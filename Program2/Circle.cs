using System;

namespace Program2
{
    public class Circle : ICalculationable
    {
        public double Pi { get; set; }
        public double R { get; set; }
        public double Area => Pi * Math.Pow(R, 2);
        public double Diameter => R * 2;

        public Circle(double R, double Pi)
        {
            this.R = R;
            this.Pi = Pi;
        }
    }
}
