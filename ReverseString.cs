using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reverseString = "";

        for(int i = (input.Length - 1); i >= 0; i--)
        {
            reverseString = reverseString + input[i];
        }

        return reverseString;
    }
}