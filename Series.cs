using System;

public static class Series
{    
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength > numbers.Length)
        {
            throw new ArgumentException("Slice length is too long!");
        }

        if(sliceLength <= 0)
        {
            throw new ArgumentException("Slice length must be a value above zero!");
        }

        if (string.IsNullOrEmpty(numbers))
        {
            throw new ArgumentException("Reference string is invalid!");
        }

        string[] resultArray = new string[((numbers.Length - sliceLength) + 1)];

        for(int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = numbers.Substring(i, sliceLength);
        }

        return resultArray;
    }
}