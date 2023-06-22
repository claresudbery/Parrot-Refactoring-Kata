namespace Parrot;

public class EuropeanParrot : IParrot
{
    private readonly Parrot _parrot;

    public EuropeanParrot(ParrotTypeEnum type)
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