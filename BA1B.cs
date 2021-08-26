using System;
using System.Collections.Generic;

namespace BA1B
{
    class Program
    {
        static void Main(string[] args)
        {
            string kmer(string text, int i, int k)
            {
                return text.Substring(i, k);
            }
            Dictionary<string,int> kmersfrequency(string text, int k)
            {
                Dictionary<string, int> D = new Dictionary<string, int>();
                for(int i = 0; i < text.Length - k + 1; i++)
                {
                    string tmp = kmer(text, i, k);
                    try
                    {
                        D[tmp] = D[tmp] + 1;
                    }
                    catch (KeyNotFoundException)
                    {
                        D[tmp] = 1;
                    }
                }
                return D;
            }

            List<string>mostfrequentkmers(string text, int k)
            {
                Dictionary<string, int> D = kmersfrequency(text, k);
                int maxcount = -1;
                foreach(string key in D.Keys)
                {
                    if (D[key] > maxcount)
                    {
                        maxcount = D[key];
                    }
                }
                List<string> keys = new List<string>();
                foreach(string key in D.Keys)
                {
                    if (D[key] == maxcount)
                    {
                        keys.Add(key);
                    }
                }
                return keys;
            }

            string x= "ACGTTGCTGTCGCATGATGCATGAGAGCT\n4";
            string[] inlines = x.Split("\n");
            string text = inlines[0];
            int k = int.Parse(inlines[1]);

            List<string> keys = mostfrequentkmers(text, k);
            foreach(string s in keys)
            {
                Console.WriteLine(s + " ");
            }
        }
    }
}
