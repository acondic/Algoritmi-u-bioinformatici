﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BA1E
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            int L = 481;
            int t = 16;

            string genom = "GCCTGCACCCGAGGTCAATAGACGTCGGCTTTAGTGCATCGGTTGTATTTCAGCTGAAAAAGTTCAACGGATCCATTGTTGGGAATCCATCGCAATCACGCCCGTGTAGCAAGCGCGGCGAGAGGAGTGGCATCAACCGGAAAAGCCCCATAGCTGTCAAATCACCCGTTGGGCTCAGTTACTTCCGCATCCATACTGGCATCGAGTTATTATCCCCGCGGGCGTTGTGACCAAAACGACGGACCCCCACAAAACGACGACTCCGTCCACCCAAAACGACGCAGGGTTTTATTACTGAGACGGAGTACTAACAGGTTTATTACTGAAAAACGACGCCATCGGAAATCGTCGAATCTACGTGCAAATGGTGTCAAAATTATTACTGATAGAGGCAGACAAAACGACGCAAAACGACGCATTATTACTGATATTACTTTATTACTGAAGGGGACGCATCAAAACGACGAAGGGCTTATTACTGAAGCACAAAACGTTATTACTGATTCTTTTATTACTGAGGCTCAATGCACTTTCTATAGGTGTTTTATTTATTTATTACTGAATAGGCTTATTACTGATTTATTACTGAGAGCGTCAAAACGTTTTATTACTGAAAAGCAGTCGTTTCTTATTACTGATTATTACTGATTATTACTGAGCAAACGACGTACTTATTACTGAGATTTGTTTCTATTTTTATTACTGAATAGGCAAAACGACCAAAACGACGAAACGACGTTATTACTGACTTTCTATAGGGTTAGGAGCCCGCTTATTACTGAGCGCATTATTACTGATTTTTATTACTGATTATTACTGAGGGCGCTGTTAACCTCTTATTACTGATTGGTCGTACCTGGCGCTTTTTTTCTATAGGCCCGAAGTGACGAAGCAGTCGCTTCACTTTCTATATTTCTATAGGATTGACACGGACCTAAAGTTTCTATAGGAGGCATTTCTATAGGAAGACGCTAGCAAGCAGTTTTCTATAGGCTAAGCAGTCGCAGCATCCGTTTCTATAGGCTATAGGCAGTCGCAGCAGTCGCGTTCCCGTCAAAAAGATTCAACAAAAAGCAGTCGCGCAGTAAGCAGTCGCAAAGAAGCAGTCGAAGCAGTCGCTCGCAAGCAGTCGCAGTCGCGTTCACCCATTCGAAAATCGCACTAGATAACTGCGGTTAAACCACTCCTATAAACACCGCCATCTCAAAGGTATCGCGTTGCAACACAAATGGTGTGCCGAGAGTGATGGACGAGCCTTTGGTCACAAGTGTGCCTGGAGGCGCGAATGAAGATGCAGTGCCGTGTCGGTTGTCTTAGCTCCTGAAAGCGACGCCTACGCAGAGACACCACAAACCACAAGTATCACATGTCTTTCGGTATGTAACAGGGTATGGAGCCTGATGTACATACGAACGAGGAGAGATGGGGCATCTAACCTCGGATACGTGTTTCTAACATACAGATCGTCGGGCACTTCTCCAGGGAGTTTGCTGTGGGTGGAAGTTCCTACACAGTTAAGGCAGTCCCAGAGATGGGTCATTGGACTCCTCGCAGTCTGGCCTCGTATTCATTTAGTCAGCCTAGGTTCCAACCCTCGACAAAGACTGATGTCTCATAAGGTGACTCAATTCTGGTACTCAGTTGTCCTAAGTTTTTTACGCCTTTTACCCAGGAAAAGTGCCTCATGGTTCCGGCTACACTCCAGCGCCCATAATTTTGTCTCGTCCGGTCTTCTGAGTACTCTCAAAGTAAAACAGTCGGTTCGTTGAGTTCAGTGTACTCGCCCCGGGTCGATACACTCGCGTCCAACAAGAGAAAGTGGAGTTCCATCTGAACTAGGATGACGAATTATATGCAAGAAGGCGATGGGAGTCCAAGGGGACGGGTAGCATTTGGTCTCCTGAACTAGAGAGACTAAGCTCCACCCACTCGTCCAGTTTAGCCATGCTACTAAGGGTATCCCGGCGACATGGTCTTAAGTGGTACATTCTCTCCCACTCGTTTTTGGGGACGCGTGTAGAACAATTGCGTTGTTGGGTATACAACGCCAGTGAAGCCTAGCGACCCTACGTCAGTCCCGGCGAGGGACGTGACGGCGAGGGAGGTCAGGGGAACTCTTCTCTCTACCGGGGCGAGCCCTTGTCCCATCCAAGGTTAAACGCGCGGCGAGGGACGAGGGAAAATCAGCGGCGAGGGAAGATTGGGTACTCTCTTTACGGCGAGGGATGCGCGAGTCCCACCCCGGCGAGGGACTAGCGCGGCGAGGGACCACCGCGTTTTAGCGGTATCGACGGATTAGCGCCTATTAACCTGGTAATGACGCTTTCAGAACCGATGGGGCACGCGGCGGCGAGGGAACTCGTGTGTCTATAATTTGGCCCTCTCTTCTCGGATACCGGACGGCGAGGGATCGTGTGAATAACCGGCGAGGGACCCGGCGACGGCGAGGGACGGCGAGGGAGGGACGAGGGATACGGCGAGGGACCGGGCGACGGCGAGGGAGAAGGGATCGGCGAGGGATGTCCACTGAGTATCGGCGAGGGACTGTTGGTTTCCTTTCAGGCGGCGAGGGAGCGGCGAGGGAACGGCGAGGGAGGCGAGGGATCCGGCGAGGGAAATAGGCACTCGGCGAGGGATAACCGGCGAGGGATGATCCGGCGAGGGAATCCGTATCGCATTTGTTGCCGGAACTACCTCATGACACCTACGTGACAACACGAGGAACCATGTACCAGTTTGTACGGCACTAAATGATTACAAAATATCATCATACCATCACCCTGGGCACAACTAGCCACAAATAGAGGAATTATGGCCGGTCAATAGCTTGCCCCGATTTCATACCTACTGAACTACGCCCTTGTAGTGCAAAATGATAGACCTTTTTGCACGTGACCGCCACGCCCGAAGCGAGCTAGGGAGACGCACAGACTCCTATCGGAGGCACGGGGCAAAAGGGCGAACTACAGGATAGGTCCTGACAGTTTGATCTCGGCCTTGTCAATACTTAACGCGTGGTCGTTTCGTCGCGGGAGGGCGCATGTGGCGGGATCCGAGGCTAGGATTTAGCCTTGCAAAGGAAGACTCTAATTACTTGTCCCCCCAGCAAGACGGCTACACCGTGGAAATACATATAAGCCGACGCCCTCTGGTTGCAATCTGACGGTGAGGTCGTCGTTAGAAAAAGAAACGTCGACGTTTGTCATTAATGGGCAAACCTTTACATAGTATGTTCGCAAGTAGAATTCTGGCTCTGTTCTATCTTCACTCTTATTGTCTACGTCTGTCGATCGTGAATGGGAAGCTCGAGAGAGTTTCAAAGTCCTGTCGTCCTCTTCATCGGTCATGGGTTCTGTTACTGCCACAAAGGCGCGGTTTATAGCGGCTCTAGTGGCGAAGTCCGTCGCGCGATCCATGGGCACTAATAAGACCATGCGGCGAATCGTATTGGCATATAGCAATAGTCAGTTATCGGCTAATGGACCAAGAGCGGGTTCGTTCGTGTCAGTCTTTGCCGTAGCGCCGAGGGGTTCTCGGTTACAATTGGGTCCGCAAGCAGCCCCTAGCGGTAACCGGGTTACTCAACGGCGTGTTCCCCTTGGAGCGCCCCTGTGAGCGCTTCACCCGGCCCATAGATCATTGATGCGAAGAGTGTGCCGGAGGTCCGGTTCAGTGATTGGCAAGGAGCAGAGAGAGCGTAATGGGGATCAGATCGGCACCGACTTACAAGTAGGGGGACAGTCTGTCACTTTGTGTCGTTTCGTCCAACACTCATAGTGTGATAAAAAGCTCTATCGGTCACGCGAATCGTAATAGCAGAGTGTAGCCAAAATTACACCGACAGAGACCGGGCCGATGAAGCTCGTCAGAGCCACCAAGACACATCACGATGGGACATCGACAGAATGGCGCCGCTGCGCGTTTTTAAGCACCCAAGTTCCTGAGCGAATACCTCATGAGGCGACTTCCATAGTCACACGTTATAACTTAGATGATAGTCAAACGCCGCATCTGGGCCCTTAACGGAGGAATGGCAGACGGGGACTAAAAGCTCGTTCAGCCTAAAAGTCGTATAACACCTGCTATGATCGATAGTATCTTTCGTTAATCCCTGTTACTCATCACAAGGCACCTGGCAGTCTCTTGTCCGCTGTTTGTCCATCCTTCCTAAAATGTACGTGACGACGACACTAAGTCGATGCCCAAGAAGCGTGATATTCCTCTAGGGCAACAAGTCCAATTGGATCTAATGTGTCGTTAAAGAGAGACGGTAGTCCCGCCGGGAAGTAAATTAGGTTATCGCCACGGAAATTGGCAGCCTGGCGCTGAAAGGGATTTAATATAGGCAACCGATTAGCCAAAGAAATAGGGGGTCTGAGTTTTAAGGTCACGAAACGCAAGGGGTGCGCCTACACACTCTTGGTCAGCGCGCAATGTGCTTGTGTCGGCCTACACTCCCAGTCGCCCCGATTGCGCTTTTCGCTGAGCCTGAATCGTATGCTACTGGCAACATCAGCGACCTATGTTGCCGCGGAGGTGCGGCCCGCCAAACTGGGGAATGGAGCTCAGCGATTGTCAATGGTGAGTTCTAGAGAGTACGATCGTCGGTCGTGTGTCGTGTCCGCCCGAGTTAGCCATTACTGCGTTGCTCTGTCAGGGGCTCGCCCGAACCGATTGACGCGGAACTTGCAAGCACCCGGCACGGAAGGCGGCAAACAAGTCCTGGAGCCTTGTGGGAGCCGCTTAGGTCCTATAATGACTAAACCTTACGGACGCAGAGCGACCTGCAGGGTCCCGTGCCGCAATGCGTAGGACAGGCAGGGTAATGGTGTTCAATGATTCTACTTAGATCCGGCAAAACTTTCAGACACTGCTTAAAGCGTTGGGGGGTGGTGTGCTACGGCTTTACTAAGGTTGGCTCCCGCAAGGCCGCACTCTGATTTGCACCTCACACGAACGCCGTACCTGTACGAGCTAACGTCTATGTGTCCGAATGGTTTTCGCGGAGCGCGAGGGGCCCGATATCTAACCAGGCGAGTGTGGGAGAAATCAAAAGCGGATTGAAAGCCCGGGTGTCCGGGTGTTTATGACCTTGCCCGGGTGTGACGGAGGCCCGGGTGTGGGTGTTTGCTCCTAGCCCGGGTGTGTGTAGGAGCTTCGTGCACGCCCGAGATACACGGGATGCCCGAGATACACGGGAGATACACGGGGCTTTCAGATACACGGTGTGTAGACAATAATCTTCGCGGTGCTCTATGCCCGGGTAGATACACGGTGTGTGAGATACACGGCACAAGATACACGGTAGATACACGGCTAGCGCCCGGGTGTCTCGGGCAGATACACGGAGATACACGGCGGTCGGGGGAGCCCGGGTGTTGTGAGATACAGATACACGGTCTCAGATACACGGGGGTGTTTCCGCGATAAGGCACAACCTCCCGATCGCAGTGCCAGATACACGGGTTATGTGCCCGGGTGTGTGTAGATACACGGTCCGCCGCAAATGGGGGGTCAGATACACGGTTTAGCGTGAAGATACACGGCGCCCGGGTGTGTAGATACACGGGAGATACACGGGTTTACTAGATACACGAGATACACGGCAAGAGGCGAGATACACGGCCTCGATGGGCCCGGGTGTCTTTCGTCTGGTCGCTGCAGATACACGGATACACGGGCGTGATCAGGTCTTGTCATCTGCGACTCTTTAGATACACGGATCCAGAGATAAGATACACGGACCCTACACGGCCAGCCGACAGTTCGTGATATGGACGTCGGACAGTGTAGGCTCACGCCGGACTGCACGACTTGCGGCTTAGTAAGGCGATTTGAGTCCTAGTAGTGTGTCATAGATTGGGGAGTCGAGCTAGCCACTCTACTCCGCGATATTTGGGATGGGGGTGAAACAAAGCGTGCTGATGAGTCATGATGAGGCTCATCTTAGGGACTACACACCAACCGGTGGGAGTTCACGGGGAGGCCACTAATACTGAGCAGTCTGAGGGCGCTCTAGATTTGATTACGCATAGGTAGAGCTGCCCAAACGAGAACTGGGACACTGCAGGCCTCATGATCACGGTCAAAACATCCGAGTATTATGCCGGATGAAAGCTGGTTACAACGTGACAATGGCGGCAAGCGGCACGTATGCGTCCTAGTATAACGGATCCTCACGGCATCAGGAGTTTGGAATAACAATCGCGGCCGCAGGGTAACTCGTAAGTCCGATAAATCATTCTATATACTACAGATTTGTGTGCAAACAGGTGCCGTGCGGAGTCTTCTGCGTTCCTCCTTCCTGCGAGGTTGACAGGACACCCTCCCGAGTAGACTGGGAAAGACACGAAAGTCAATCCCTACCGTCTAACTTCTCGGCGTGTTTTTCAGCCGACCAAAACTCTGGCCGCCCATAGAAGAGAGCCTATAAATTCTTGCACTGGTTTATCATTAGGGTGCCCTCATTCAAACGGAACACCGGTAATCTAACAACGTCCAAACGTCGGGGAAGGCCAGAAGGAGGTTCTCCAGACGTCCAAACCGCAGCATAGACCCCACAAACGTCCAAACGTCCAAACATTATGAACGTCCAAACGTCCAAACGGGGCACTTGGGTAACGGCCCGTACGTCCAAACCTAGTGCTCTTGCAGATTTTACGTCCAAAACGTCCAAACGGTACCACTACTATAACAGGAGACAACGTCCAAACAAACGCTCTAAGGCTATGACGTCCAAACCTACATAAACTCGTTTGTTGTGGACGTCCAAACGTCCAAACTCCAAACACTACCAAAAGCTTGTACTAACGACGTCCAAACGTCCAAACCCAAACCCGAACCTCCTCTACCCGTGACTATTACGGGAGCCGGGTCCTCGCAACAGGCACGTCCAAACGTCCAAACGGGCATCGTACGTGACTGGCGTACGTCCAAACAGCTAACGACTTGTCCCCCCAATAACTTGTACGTCCAAACGCTCTAGACTAACCTCGTCCACGTCCAAGCTCTAGACTGTGCTCTAGACTAACCCAACGCTCTAGACGCTCTAGACTGACGTCCAAACGAAGCTCTAGACTGCTCTAGACTCTGGGCCCTGGACAAGCGTTGACAGTGGCGCCACTGCATGACAGCTCTAGACTGGGTTTCCCAGCTCTAGACTTGAGGAGCTCTAGACTGCTCTAGACTTGCTCTAGAGCTCTAGACTCCTCCTGGGGCTCTAGACTTGATCGGCCTACGGCACCATGTTTCTTTAGAATAGATATCACAGCTCTAGACTCAGTGTTCCTGGCTCTAGACTCGTGGCTCTAGACTGCGCGCTTCATGCCTCAAGCTCTAGACTCTGTTCAAACGCCGCCATTAGGCTTTGGACGCTCTAGACTGCGTACTCCCGCTCTAGACTCCAGGGAGCTCTAGACTTTGGCTCGCTCTAGACTATTTCCTCTAGCCCCTTAGCCCTCGGCACCCGTGTTAGAGTTCGTTGAGTCGCTCTAGACTCTAGACTTACGGCCGTGAGCTCTAGACTTCTAGACTATTTCTGTACCTGCCCAGAGTTTCAGGACACACTGCGGTGTCAACGTCGGATTCGTCCTACCAACACGACCATGCGGTGTGTTGACCGTAGGGAATGCTATATGCAGGGCCTACTGTAGCGGCTTCAATGAAGAGGCAGTTACTAAGTTGAAACGACGTGTGGCTCCTGTGATAGAGCGAACCATGATACGTTTAAGTCAGGTTGGAATCTCTGCCGCTTGGTTAGCGGGTACCTCAAGTTCTAGTTTGAAGTGTTTTTTTCTATAAATTGACCTGAAACCGGAAGGCAACGACCCCTTTCGGAGTACTGTGTACTCAGGGGTGTTACCAAGTATTGAATCAGGAACTTCGCACCAAATCCGGAGAGACTAAGTCCCTCTGTCGTGCCTCATGTTGTGCCTTGCGTGTGGAAAGTAAATGACCGCCGTATGACCGCCGTGTCTTTAGTGGTATGACCGCCGTTGTAGGTCGGTGATAGGATGACATGACCGCCGGCCCTAATGACCGCCGCAGATCTTTATGAGCAATGACCGCCGATCAGCTACTGATCAATGACCGCCGACCGCCGCATGACCGCCGATGATGACCGCCGCGCTACATTCCAGATGACCGCCGGTGACCGCCGGTCGGAGATGACCGCCGCATCGCATAACACAGACGGACTAATTCTTAATGACCGCCGTGGTCCCGGAGTGTCCTACTAAACATGACCGCCGGCGTATTCACTATTACGCTTCTCTATCCAAATGACCGCCGCGTGGCGAGCCTAATGACCGCCGGGGCTGTAATGACCGCCGCTAGAAATGCCCTATATGAATGACCGCCGCCCGATGTCTCCATATTATGACCGCCGACAGCACCGGTAGCGTTTATATCTAGTATTAAGATGTTCCTGGGTGTCCGAGATCCCGCAGTCCGAGATCAGTCCGAGATCGTCCGAGATCGAGTCCGAGATCGTCCGAGATCCGTCCGAGATCGCCGTGGTCCGAGATCAGATCCAGGCAAATGACCGTCCGAGATCATCATAGCCTATTGCTGCTATTGCTGCTGCAATGTCCGAGACTATTGCTGCAGATCGAATCATCCATCCGTCTATTGCTGCCGAGATCGATCGTCCAAACTATTGCTGCCGAGACTCTATTGCTGTGACCTCAGACCGAGATTGACCTCAGACACTGACCTCAGAAGGCAACTATTGCTGCTTCCTTGACCTCAGATGCTGCGTGACCTCAGATGCTGCCGACTATTGCTGTGACCTCAGACATAATGACCTCAGATCTATTGCTGCATCGTTCCTATTGCTGCCTGTGGATTGATGACCTCAGAGAAGGTCCGAGATCCGAGATCCTGATGACCTCTGACCTCAGATGACCTCAGACAGACATCCTTTGACCTCAGAGACCTCAGATCCGAGATCTTGTCCGAGCTATTGACCTCAGACACCGCTATTGCTGCCTTGACCTCAGAGGCTTACACGGCTACACTATTATTCCTATTTGACCTCAGAAGATATATGACCTCAGAGCGCTGCAAATGACCTTGACCTCAGATTGCTGCTGCTATTGCCTATTGCTGCCCAGCTATTCTATTGTGACCTCAGTGACCTCAGATTCTATTGCTGCCGGTTTGGTCGCAGCCTTCGCCTATTGGCTGACCTCAGAACAACACACAGGCAGTTGACCTCAGATTGACCTCAGAAGACGCCCAGAGGCAACTGCCATAGTGACCTCAGATATCGGACAGTATTACGGGGGGAAGAAATTGAAGTCCTTGAATGGGAACTGCATCTTCATATCGCTTTTACGGCTACCATTAATAGACCCGAACCCAGACAACGCAAAGGAACTGATGAAATAAATTATACCATCATGTTGATCCTTTTCAAGGACAAAGTAAGCAACTTCGGAAGTGTCAGCGGGCTCGGCATATCTTACACGCCGATATAGCGCGCCTTCAAAGCATATGGGAGCCCTTTCCCTATATCAGCTGAACTGGAGCATAGACTTAGTTCCACAGGCGTCAGAAGGCGGCCAGACTGGATGCTCCTCTGCAAGATAACATTTGCCTTATGGCGAGATCTTGAGTAAGGAAATTGAACTCACTTCGCGTGTTTGGTCAGTTCTCCGAAGGTCAGGGCGGGAATCGGGAATAGGTACCAATCGTCCTTCTCAGGAAAGTTTGGTAAGGCTCTCGCTGATGTTTGGTTCCCCTACATGAAGCCGATCGCTGTCGCGACTGTTGGCTGAAATTTGATACAGCTTGTCCGCCTTGTCGACGCCCAAATTTTCGCTGTTATGGGTAAAGCTATTTGGTCCAGAGTAAAAGAGCGAGGTAACATT";
            List<string> lista = new List<string>();
            for(int i = 0; i < genom.Length - L; i++)
            {
                for (int j = 0; j < i + L - k; j++)
                {
                    string s = genom.Substring(j, k);
                    int count = 0;
                    for(int m = i; m < i + L - k; m++)
                    {
                        if (genom.Substring(m, k) == s)
                            count++;
                    }
                    if (count >= t)
                        lista.Add(s);
                }
            }

            foreach(string cl in lista.Distinct())
            {
                Console.Write(cl + " ");
            }
            Console.ReadLine();
        }
    }
}
