namespace Parrot;

public class EuropeanParrot : IParrot
{
    private readonly Parrot _parrot;

    public EuropeanParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _parrot = new Parrot(type);
    }

    public double GetSpeed()
    {
        return _parrot.GetBaseSpeed();
    }

    public string GetCry()
    {
        return "Sqoork!";
    }
}