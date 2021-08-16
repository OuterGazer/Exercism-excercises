using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    static string[] referenceArray = new string[]
    {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
     "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
     "u", "v", "w", "x", "y", "z"};

    public static bool IsPangram(string input)
    {
        input = input.ToLower();

        char[] temp = input.ToCharArray();
        List<string> inputLetters = new List<string>();

        foreach(char item in temp)
        {
            if (!inputLetters.Contains(Convert.ToString(item)))
            {
                inputLetters.Add(Convert.ToString(item));
            }            
        }        

        for (int i = 0; i < inputLetters.Count; i++)
        {
            if (!referenceArray.Contains(inputLetters[i]))
            {
                inputLetters.RemoveAt(i);
            }
            if (inputLetters.Contains("1"))
            {
                inputLetters.Remove("1");
            }
        }

        inputLetters.Sort();

        if (inputLetters.SequenceEqual(referenceArray))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
