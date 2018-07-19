using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");

            nucleotide = nucleotide.Replace("G","temp1");
            nucleotide = nucleotide.Replace("C","temp2");
            nucleotide = nucleotide.Replace("T","temp3");
            nucleotide = nucleotide.Replace("A","temp4");

            nucleotide = nucleotide.Replace("temp1","C");
            nucleotide = nucleotide.Replace("temp2","G");
            nucleotide = nucleotide.Replace("temp3","A");
            nucleotide = nucleotide.Replace("temp4","U");

            return nucleotide;
        }
    }
}
