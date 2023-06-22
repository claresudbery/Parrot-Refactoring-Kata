using System;

namespace Parrot;

public class NorwegianBlueParrot : IParrot
{
    private readonly Parrot _parrot;
    private readonly bool _isNailed;
    private readonly double _voltage;

    public NorwegianBlueParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
        _parrot = new Parrot(type);
    }

    public double GetSpeed()
    {
        return _isNailed ? 0 : GetBaseSpeed(_voltage);
    }

    private double GetBaseSpeed(double voltage)
    {
        return Math.Min(24.0, voltage * _parrot.GetBaseSpeed());
    }

    public string GetCry()
    {
        return _voltage > 0 ? "Bzzzzzz" : "...";
    }
}