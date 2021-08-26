using System;

namespace BA1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int PatternCount(string text,string pattern)
            {
                int count = 0;
                for(int i = 0; i < text.Length - pattern.Length; i++)
                {
                    if (text.Substring(i, pattern.Length) == pattern)
                    {
                        count++;
                    }
                }
                return count;
            }

            string a = "TAACAGCCTTTAGCCTTTAGCCTTTAGCCTTTAGCCTTTAGCCTTTGAGCCTTTGAGCCTTTTAGCCTTTCAGCCTT\nCCT";
            string[] inlines = a.Split("\n");
            string text = inlines[0];
            string pattern = inlines[1];

            int broj = PatternCount(text, pattern);
            Console.WriteLine("Broj ponavljanja je:" + broj);
        }
    }
}
