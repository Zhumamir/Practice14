using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice14
{
    class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится " +
                          "В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет " +
                          "пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            text = Regex.Replace(text, @"[^\w\s]", string.Empty).ToLower();

            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordStatistics = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordStatistics.ContainsKey(word))
                {
                    wordStatistics[word]++;
                }
                else
                {
                    wordStatistics[word] = 1;
                }
            }
            Console.WriteLine("Статистика по тексту:");
            Console.WriteLine("Слово\t\tКоличество");

            foreach (var kvp in wordStatistics)
            {
                Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
            }
        }
    }
}
