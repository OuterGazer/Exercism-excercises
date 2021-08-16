using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int[] arrayForSearch = input;
        int valueAtMiddle;
        int loopCounterToUpperBound = 0;
        int loopCounterToLowerBound = 0;

        while (true)
        {
            if (arrayForSearch.Length == 0)
                break;

            valueAtMiddle = arrayForSearch[arrayForSearch.Length / 2];

            if (valueAtMiddle == value)
            {
                int convertedIndex;

                if ((loopCounterToLowerBound == 0) && (loopCounterToUpperBound == 0))
                    return convertedIndex = (input.Length / 2);

                if((loopCounterToLowerBound != 0) && (loopCounterToUpperBound == 0))
                    return convertedIndex = (input.Length / 2) - (loopCounterToLowerBound + 1);

                if ((loopCounterToLowerBound == 0) && (loopCounterToUpperBound != 0))
                    return convertedIndex = (input.Length / 2) + (loopCounterToUpperBound + 1);

                if(value > input[input.Length / 2])
                    return convertedIndex =
                    (input.Length / 2) -
                    (loopCounterToLowerBound * loopCounterToLowerBound) +
                    (loopCounterToUpperBound * loopCounterToUpperBound);

                if (value < input[input.Length / 2])
                    return convertedIndex =
                    (input.Length / 2) /
                    (loopCounterToLowerBound * 2) +
                    (loopCounterToUpperBound);
            }

            if(value < valueAtMiddle)
            {
                int[] tempArray = new int[arrayForSearch.Length / 2];

                for (int i = 0; i < (arrayForSearch.Length / 2); i++)
                {
                    tempArray[i] = arrayForSearch[i];
                }

                Array.Resize<int>(ref arrayForSearch, (arrayForSearch.Length / 2));
                arrayForSearch = tempArray;

                loopCounterToLowerBound++;
            }

            if(value > valueAtMiddle)
            {
                int count = arrayForSearch.Length / 2;
                int[] tempArray = new int[count];

                for (int i = (arrayForSearch.Length - 1); i > (arrayForSearch.Length / 2); i--)
                {
                    tempArray[count - 1] = arrayForSearch[i];
                    count--;
                }

                Array.Resize<int>(ref arrayForSearch, (arrayForSearch.Length / 2));
                arrayForSearch = tempArray;

                loopCounterToUpperBound++;
            }
        }

        return -1;

        //or was the point of the exercise just writing a single line?
            //return Array.BinarySearch(input, value);
    }
}