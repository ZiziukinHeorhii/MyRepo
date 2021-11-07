using System;
using System.Text.RegularExpressions;

namespace Program2
{
    public static class ValidationHelper
    {
        public static double InputFormatCheck(Regex reg)
        {
            double value = 0;

            for (int i = 0; i < 3; ++i)
            {
                string input = Console.ReadLine().Replace(".", ",");

                if (i == 2 && !reg.IsMatch(input))
                {
                    value = new Random().NextDouble() * (5 - 0.5) + 0.5;
                    Console.Write("Было выбрано случайно число от 0.5 до 5: " + Math.Round(value, 2) + "\n");
                    return value;
                }
                else if (reg.IsMatch(input))
                {
                    value = Convert.ToDouble(input);
                    return value;
                }
                else
                {
                    Console.Write("Разрешено вводить только цифры, попробуйте ещё раз: ");
                }
            }
            return value;
        }        
    }
}
