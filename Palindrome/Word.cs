using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class Word
    {
        public string word { get; set; }
        public string reverseWord { get; set; }
        public char[] arr { get; set; }

        public Word(string word, char[] arr)
        {
            this.word = word;
            this.arr = arr;
        }

        public bool IsPalindrome()
        {
            for (int i = 0; i < word.Length; ++i)
            {
                arr[i] = word[word.Length - i - 1];
            }

            reverseWord = new string(arr);

            if (word == reverseWord)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
