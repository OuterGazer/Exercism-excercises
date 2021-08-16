using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> multiplesToSum = new List<int>();

        foreach (int i in multiples.ToArray())
        {
            if(i != 0)
            {
                for (int j = 1; j < max; j++)
                {
                    if (((j % i) == 0) && !(multiplesToSum.Contains(j)))
                    {
                        multiplesToSum.Add(j);
                    }
                }
            }            
        }

        return multiplesToSum.Sum();
    }
}