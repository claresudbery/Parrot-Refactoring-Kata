using System;

namespace Parrot;

public class NorwegianBlueParrot : IParrot
{
    private readonly double _voltage;
    private readonly bool _isNailed;

    public NorwegianBlueParrot(double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
    }

    public double GetSpeed()
    {
        return _isNailed ? 0 : GetBaseSpeed(_voltage);
    }

    public string GetCry()
    {
        return _voltage > 0 ? "Bzzzzzz" : "...";
    }

    private static double GetBaseSpeed(double voltage)
    {
        return Math.Min(24.0, voltage * Parrot.GetBaseSpeed());
    }
}