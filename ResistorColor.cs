using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int correspondingColor = 0;

        for (int i = 0; i < Colors().Length; i++)
        {
            if (Colors()[i].Contains(color) == true)
            {
                correspondingColor = i;
            }
        }

        return correspondingColor;
    }

    public static string[] Colors()
    {
        string[] resistorColors = new string[10]
        { 
        "black", "brown", "red", "orange",
        "yellow", "green", "blue", "violet",
        "grey", "white"
        };

        return resistorColors;
    }
}