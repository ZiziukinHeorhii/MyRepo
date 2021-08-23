using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    class Word
    {
        private string word;
        private string reverseWord;
        private char[] arr;

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
