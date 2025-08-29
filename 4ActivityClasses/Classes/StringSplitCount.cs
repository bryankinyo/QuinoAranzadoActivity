using System;
using ArrayActivity.Interfaces;

namespace ArrayActivity.Implementations
{
    public class StringSplitCount : IStringSplitCount
    {
        public int CountWords(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
