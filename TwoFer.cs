using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string personName = null)
    { 
        string twoFer;
        if (personName == null)
        {
            twoFer = "One for you, one for me.";
        }
        else
        {
            twoFer = "One for " + personName + ", one for me.";
        }
        return twoFer;
    }
}
