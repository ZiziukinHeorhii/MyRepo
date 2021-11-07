using System;

namespace Program2
{
    public class Square : ICalculationable
    {
        public double A { get; set; }
        public double Area => Math.Pow(A, 2);
        public double Diagonal => A * Math.Sqrt(2);

        public Square(double A)
        {
            this.A = A;
        }
    }
}
