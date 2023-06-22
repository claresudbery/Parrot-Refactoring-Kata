using System;

namespace Parrot;

public class AfricanParrot : IParrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(int numberOfCoconuts)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public double GetSpeed()
    {
        return Math.Max(0, Parrot.GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
    }

    public string GetCry()
    {
        return "Sqaark!";
    }

    public static double GetLoadFactor()
    {
        return 9.0;
    }
}