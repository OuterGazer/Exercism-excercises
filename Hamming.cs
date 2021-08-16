using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;

        if (firstStrand.Length == secondStrand.Length)
        {
            firstStrand.Split();
            secondStrand.Split();
            for(int i = 0; i < firstStrand.Length; i++)
            {
                if(firstStrand[i] != secondStrand[i])
                {
                    hammingDistance += 1;
                }
            }

            return hammingDistance;
        }
        else
        {
            if ((firstStrand.Length == 0) || (secondStrand.Length == 0))
            {
                throw new ArgumentException("The strands can't be empty!");
            }
            else
            {
                if (firstStrand.Length < secondStrand.Length)
                {
                    throw new ArgumentException("The second DNA strand is too long!");
                }

                if (firstStrand.Length > secondStrand.Length)
                {
                    throw new ArgumentException("The first DNA strand is too long!");
                }
            }
        }

        return hammingDistance;
    }
}