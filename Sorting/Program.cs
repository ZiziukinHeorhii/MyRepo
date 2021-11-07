using System;
using System.Collections.Generic;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 54, -35, -43, 72, 67, 25, 85 };

            Console.Write("Список: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");

            //QuickSort qs = new QuickSort();
            //qs.Sort(numbers, 0, numbers.Count);

            MergeSort ms = new MergeSort();
            numbers = ms.Sort(numbers);

            Console.Write("Отсортированный список: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\n");
        }
    }
}
