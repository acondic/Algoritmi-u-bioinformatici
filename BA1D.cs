using System;
using System.Collections.Generic;

namespace BA1D
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "GTC";
            string g = "ACTGGTCACCGTAGTCAA";
            List<int> lista = new List<int>();
            for(int i = 0; i < g.Length - p.Length; i++)
            {
                if (g.Substring(i, p.Length) == p)
                {
                    lista.Add(i);
                }
            }

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i] + " ");
            }
        }
    }
}
