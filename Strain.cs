using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {        
        List<T> keptCollection = new List<T>(); //Create a manageable collection

        foreach (T item in collection) //add everything from the input collection to our list
            keptCollection.Add(item);

        for(int i = 0; i < keptCollection.Count; i++) //loop through the list, invoke the user function, if false then remove item
        {
            if (!predicate.Invoke(keptCollection[i]))
            {
                keptCollection.RemoveAt(i);
                i--; //remove one index so consecutive items that should be removed are removed. If not the loop jumps through to the next item and ignores the inmediately posterior.
            }
        }            

        return keptCollection.ToArray(); //Array is expected
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> discardedCollection = new List<T>();

        foreach (T item in collection)
            discardedCollection.Add(item);

        for (int i = 0; i < discardedCollection.Count; i++)
        {
            if (predicate.Invoke(discardedCollection[i]))
            {
                discardedCollection.RemoveAt(i);
                i--;
            }
        }

        return discardedCollection.ToArray(); ;
    }
}