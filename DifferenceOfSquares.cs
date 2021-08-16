using System;
using System.Collections.Generic;
using System.Linq;

public static class DifferenceOfSquares
{
    static List<int> intCollection = new List<int>();

    static int sumOfSquares = 0;

    static int squareOfSum = 0;

    public static void CreateCollection(int inMaxNumber)
    {
        intCollection.Clear();

        for (int i = inMaxNumber; i > 0; i--)
        {
            intCollection.Add(i);
        }
    }

    public static int CalculateSquareOfSum(int max)
    {
        CreateCollection(max);         

        return squareOfSum = (int)Math.Pow(intCollection.Sum(), 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        CreateCollection(max);

        for(int i = 0; i < intCollection.Count; i++)
        {
            intCollection[i] = (int)Math.Pow(intCollection[i], 2);
        }

        return sumOfSquares = intCollection.Sum();
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        CalculateSquareOfSum(max);

        CalculateSumOfSquares(max);

        return squareOfSum - sumOfSquares;
    }
}