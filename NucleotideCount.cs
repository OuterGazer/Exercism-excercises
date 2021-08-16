using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    static IDictionary<char, int> dnaStrand = new Dictionary<char, int>();

    public static IDictionary<char, int> Count(string sequence)
    {
        if(sequence.Replace("A", "").Replace("C", "").Replace("G", "").Replace("T","").Trim().Length != 0)
        {
            throw new ArgumentException("The sequence given contains invalid characters!");
        }
        else
        {
            dnaStrand.Clear();
            dnaStrand.Add('A', 0);
            dnaStrand.Add('C', 0);
            dnaStrand.Add('G', 0);
            dnaStrand.Add('T', 0);

            for (int i = 0; i < sequence.Length; i++)
            {
                if (dnaStrand.ContainsKey(sequence[i]))
                {
                    dnaStrand[sequence[i]] += 1;
                }
            }

            return dnaStrand;
        }
    }
}