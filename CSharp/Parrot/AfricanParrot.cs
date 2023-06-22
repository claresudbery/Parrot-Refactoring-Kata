using System;

namespace Parrot;

public class AfricanParrot : IParrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public double GetSpeed()
    {
        return Math.Max(0, Parrot.GetBaseSpeed() - Parrot.GetLoadFactor() * _numberOfCoconuts);
    }

    public string GetCry()
    {
        return "Sqaark!";
    }
}