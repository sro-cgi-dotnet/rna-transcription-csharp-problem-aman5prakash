using System;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            StringBuilder rna = new StringBuilder();

            int n = nucleotide.Length;
           for (int i = 0; i < n; i++)
            {
                switch (nucleotide[i])
                {
                    case 'G':
                        rna.Append ('C');
                        break;
                    case 'C':
                        rna.Append('G');
                        break;
                    case 'T':
                        rna.Append('A');
                        break;
                    case 'A':
                        rna.Append('U');
                        break;
                    default:
                        break;
                }         
            }
            return rna.ToString();
        }
    }
}



 