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
        _parrot = new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public double GetSpeed()
    {
        return _isNailed ? 0 : _parrot.GetBaseSpeed(_voltage);
    }

    public string GetCry()
    {
        return _parrot.GetCry();
    }
}