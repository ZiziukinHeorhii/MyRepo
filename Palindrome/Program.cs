using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string input = Console.ReadLine();

            char[] arr = new char[input.Length];

            Word word = new Word(input, arr);

            if (word.IsPalindrome())
            {
                Console.WriteLine("Это слово является палиндромом");
            }
            else
            {
                Console.WriteLine("Это слово НЕ является палиндромом");
            }
        }
    }
}
