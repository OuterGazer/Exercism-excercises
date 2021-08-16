using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string rainDrop = "";

        if((number % 3) == 0)
        {
            rainDrop += "Pling";
        }

        if((number % 5) == 0)
        {
            rainDrop += "Plang";
        }

        if((number % 7) == 0)
        {
            rainDrop += "Plong";
        }

        if(rainDrop == "")
        {
            rainDrop = number.ToString();
        }

        return rainDrop;
    }
}