using System;

public class SpaceAge
{
    double secondsForCalc;
    const double SECONDS_IN_EARTH_YEAR = 31_557_600;
    const double MER_ORB_PERIOD = 0.2408467;
    const double VEN_ORB_PERIOD = 0.61519726;
    const double MAR_ORB_PERIOD = 1.8808158;
    const double JUP_ORB_PERIOD = 11.862615;
    const double SAT_ORB_PERIOD = 29.447498;
    const double URA_ORB_PERIOD = 84.016846;
    const double NEP_ORB_PERIOD = 164.79132;

    public SpaceAge(int seconds)
    {
        secondsForCalc = seconds;
    }

    public double OnEarth()
    {
        return (secondsForCalc / SECONDS_IN_EARTH_YEAR);
    }

    public double OnMercury()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * MER_ORB_PERIOD);
    }

    public double OnVenus()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * VEN_ORB_PERIOD);
    }

    public double OnMars()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * MAR_ORB_PERIOD);
    }

    public double OnJupiter()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * JUP_ORB_PERIOD);
    }

    public double OnSaturn()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * SAT_ORB_PERIOD);
    }

    public double OnUranus()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * URA_ORB_PERIOD);
    }

    public double OnNeptune()
    {
        return secondsForCalc / (SECONDS_IN_EARTH_YEAR * NEP_ORB_PERIOD);
    }
}