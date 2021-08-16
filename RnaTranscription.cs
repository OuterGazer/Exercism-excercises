using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string[] splitNucleotide = new string[nucleotide.Length];
        char[] temp = nucleotide.ToCharArray();

        for(int i = 0; i < temp.Length; i++)
        {
            splitNucleotide[i] = Convert.ToString(temp[i]);
        }

        for(int i = 0; i < splitNucleotide.Length; i++)
        {
            if (splitNucleotide[i] == "G")
            {
                splitNucleotide[i] = "C";
                continue;
            }
            if (splitNucleotide[i] == "C")
            {
                splitNucleotide[i] = "G";
                continue;
            }
            if (splitNucleotide[i] == "T")
            {
                splitNucleotide[i] = "A";
                continue;
            }
            if (splitNucleotide[i] == "A")
            {
                splitNucleotide[i] = "U";
            }
        }

        return String.Join("", splitNucleotide);
    }
}