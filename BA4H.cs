using System;
using System.Collections.Generic;
using System.Linq;

namespace BA4H
{
    class BA4H
    {
        public static List<int> Convolution(List<int> spectrum)
        {
            spectrum.Sort();//sortiram na pocetku pa da odmah mogu gledati razlike
            List<int> conv = new List<int>();
            for (int i = 0; i < spectrum.Count() - 1; i++)
            {
                for (int j = i; j < spectrum.Count(); j++)
                {
                    if (spectrum[j] - spectrum[i] != 0)//pazim da je razlika razlicita od 0
                        conv.Add(spectrum[j] - spectrum[i]);
                }
            }
            Dictionary<int, int> freq_dict = new Dictionary<int, int>();
            foreach (int mass in conv.Distinct())
                freq_dict[mass] = conv.Count((element) => element == mass);//svakom razlicitom elementu iz razlika za vrijednost dodam broj ponavljanja

            List<int> rj = new List<int>();


            foreach (KeyValuePair<int, int> vrij in freq_dict.OrderByDescending(key => key.Value))//pazim da je poredano po vrijednostima
            {
                for (int k = 0; k < vrij.Value; k++)
                    rj.Add(vrij.Key);
            }
            return rj;
        }
        static void Main(string[] args)
        {
            string s = "0 137 186 323";
            List<int> spectrum = new List<int>();
            foreach (string m in s.Split(' '))
            {
                spectrum.Add(int.Parse(m));
            }
            List<int> rj = Convolution(spectrum);
            for (int i = 0; i <= rj.Count() - 1; i++)//obrnuto ih ispisujem
                Console.Write(rj[i] + " ");
            Console.ReadLine();
        }
    }
}
