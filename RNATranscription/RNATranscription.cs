using System;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            // StringBuilder to create a new string object
            StringBuilder rna = new StringBuilder();

            int n = nucleotide.Length;

            // To take each char of string nucleotide
            for (int i = 0; i < n; i++)
            {
                //append each character in stringbuilder object
                switch (nucleotide[i])
                {
                    case 'G':
                        rna.Append('C');
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
                        throw (new ArgumentException("Invalid DNA Sequence"));
                        break;
                }
            }
            return rna.ToString();
        }
    }
}



