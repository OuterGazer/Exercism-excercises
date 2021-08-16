using System;
using System.Linq;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newSystem = new Dictionary<string, int>();

        IEnumerable<int> forKeys = old.Keys;
        IEnumerable<string[]> forValues = old.Values;

        int count = 0;

        foreach(string[] item in forValues)
        {
            foreach(string s in item)
            {
                newSystem.Add(s.ToLower(), forKeys.ElementAt<int>(count));
            }

            count++;
        }

        return newSystem;
    }
}