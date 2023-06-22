using System;

namespace Parrot;

public class AfricanParrot : IParrot
{
    private const double LoadFactor = 9.0;
    private readonly Parrot _parrot;
    private readonly int _numberOfCoconuts;

    public AfricanParrot(ParrotTypeEnum type, int numberOfCoconuts)
    {
        _numberOfCoconuts = numberOfCoconuts;
        _parrot = new Parrot(type);
    }

    public double GetSpeed()
    {
        return Math.Max(0, _parrot.GetBaseSpeed() - LoadFactor * _numberOfCoconuts);
    }

    public string GetCry()
    {
        return "Sqaark!";
    }
}