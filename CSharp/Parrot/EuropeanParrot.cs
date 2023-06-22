namespace Parrot;

public class EuropeanParrot : IParrot
{
    private readonly Parrot _parrot;

    public EuropeanParrot()
    {
        _parrot = new Parrot();
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