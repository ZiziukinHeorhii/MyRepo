using System;
using System.Text.RegularExpressions;

namespace Program2
{
    public class Program
    {
        public const double Pi = 3.14;
        public static Regex reg = new Regex(@"^[0-9]+\.[0-9]+|[0-9]+\,[0-9]+|^[0-9]+$");
        static void Main(string[] args)
        {
            //Circle
            Console.Write("Введите радиус круга: ");
            Circle circle = new Circle(ValidationHelper.InputFormatCheck(reg), Pi);
            Console.Write("Площадь круга: " + Math.Round(circle.Area, 2) + "\n" + "\n");

            //Square
            Console.Write("Введите длину стороны квадрата: ");
            Square square = new Square(ValidationHelper.InputFormatCheck(reg));
            Console.Write("Площадь квадрата: " + Math.Round(square.Area, 2) + "\n" + "\n");

            //IsFit
            if (square.Diagonal <= circle.Diameter)
            {
                Console.WriteLine("Квадрат помещается в круг");
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг");
            }

            if (circle.Diameter <= square.A)
            {
                Console.WriteLine("Круг помещается в квадрат");
            }
            else
            {
                Console.WriteLine("Круг не помещается в квадрат");
            }
        }
    }
}
