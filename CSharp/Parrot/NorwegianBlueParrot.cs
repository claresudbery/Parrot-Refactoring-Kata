namespace Parrot;

public class NorwegianBlueParrot : IParrot
{
    private readonly double _voltage;
    private readonly bool _isNailed;
    private readonly Parrot _parrot;

    public NorwegianBlueParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
        _parrot = new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public double GetSpeed()
    {
        return _isNailed ? 0 : Parrot.GetBaseSpeed(_voltage);
    }

    public string GetCry()
    {
        return _voltage > 0 ? "Bzzzzzz" : "...";
    }
}