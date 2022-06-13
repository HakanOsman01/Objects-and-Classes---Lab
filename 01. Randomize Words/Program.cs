using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            Random random = new Random();
            for(int i = 0; i < words.Length; i++)
            {
                int wordIndex = random.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[wordIndex];
                words[wordIndex] = currentWord;
            }
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
