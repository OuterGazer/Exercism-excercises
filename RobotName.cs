using System;
using System.Collections.Generic;

public class Robot
{
    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string numbers = "0123456789";
    string name = null;

    Random rndSelector = new Random();

    static HashSet<string> nameList = new HashSet<string>();

    public string GenerateName()
    {        
        do
        {
            name = null;

            for (int i = 0; i < 2; i++)
            {
                name += chars[rndSelector.Next(0, chars.Length)];
            }
            for (int i = 0; i < 3; i++)
            {
                name += numbers[rndSelector.Next(0, numbers.Length)];
            }
            if (nameList.Add(name))
            {
                break;
            }
        } while (true);

        return name;
    }

    public string Name
    {
        get
        {
            if (nameList.Contains(name))
            {
                return name;
            }
            else
            {
                return GenerateName();
            }
        }
    }

    public void Reset()
    {
        name = null;
        GenerateName();
    }


}