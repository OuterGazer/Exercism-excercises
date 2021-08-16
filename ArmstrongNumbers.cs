using System;

public static class ArmstrongNumbers
{    
    public static bool IsArmstrongNumber(int number)
    {        
        int[] resultArray = new int[number.ToString().Length];

        int numberTemp = number;

        for(int i = 0; i < resultArray.Length; i++)
        {
            resultArray[i] = numberTemp % 10;

            resultArray[i] = (int)Math.Pow(resultArray[i], number.ToString().Length);

            numberTemp /= 10;
        }

        int totalSum = 0;

        foreach(int i in resultArray)
        {
            totalSum += i;
        }

        if(totalSum == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}