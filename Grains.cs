using System;
using System.Collections.Generic;

public static class Grains
{
    static List<ulong> grainsInSquare = new List<ulong>();

    public static ulong Square(int n)
    {
        if((n <= 0) || (n > 64))
        {
            throw new ArgumentOutOfRangeException("The number given is out of range! It must lay between 1 and 64");
        }
        else
        {
            grainsInSquare.Clear();

            for (int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    grainsInSquare.Add(1);
                }
                else
                {
                    grainsInSquare.Add(grainsInSquare[i - 1] * 2);
                }                
            }

            return grainsInSquare[n-1];
        }
    }

    public static ulong Total()
    {
        Square(64);

        ulong totalSumInBoard = 0;

        foreach(ulong item in grainsInSquare)
        {
            totalSumInBoard += item;
        }

        return totalSumInBoard;
    }
}