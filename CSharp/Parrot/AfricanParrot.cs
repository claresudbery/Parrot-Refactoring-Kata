using System;

namespace Parrot;

public class AfricanParrot : IParrot
{
    private readonly Parrot _parrot;
    private readonly int _numberOfCoconuts;

    public AfricanParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _numberOfCoconuts = numberOfCoconuts;
        _parrot = new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public double GetSpeed()
    {
        return Math.Max(0, _parrot.GetBaseSpeed() - _parrot.GetLoadFactor() * _numberOfCoconuts);
    }

    public string GetCry()
    {
        return "Sqaark!";
    }
}