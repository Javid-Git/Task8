using System;

namespace Task8_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozleri daxil edin!");
            string[] tema = { "Alma", "Vanna", "Heyva", "Lampa" };
            char herf = 'v';
            Console.WriteLine(CharinIndex(tema, herf));
        }
        static string CharinIndex(string[] a, char b)
        {
            string words = "";
            for (int i = 0; i < a.Length; i++)
            {
                foreach (char item in a[i])
                {
                    char p = item;
                    if (p == b)
                    {
                        words += a[i] + " ";
                    }
                }
            }return words;
        }
    }
}
