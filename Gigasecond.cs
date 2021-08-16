using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        //Also potentially correct moment = moment.AddSeconds(1000000000) and then return moment again
        //Created a new DateTime object for clarity
        
        DateTime futureMoment = moment.AddSeconds(1000000000);

        return futureMoment;
    }
}