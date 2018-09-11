using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna = null;
            int n = nucleotide.Length;
            for (int i = 0; i < n; i++)
            {
                switch (nucleotide[i])
                {
                    case 'G':
                        rna += 'C';
                        break;
                    case 'C':
                        rna += 'G';
                        break;
                    case 'T':
                        rna += 'A';
                        break;
                    case 'A':
                        rna += 'U';
                        break;
                    default:
                        break;
                }               
            }
            return rna;
        }
    }
}