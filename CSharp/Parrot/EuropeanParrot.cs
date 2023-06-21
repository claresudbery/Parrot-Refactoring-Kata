namespace Parrot;

public class EuropeanParrot : IParrot
{
    public double GetSpeed()
    {
        return Parrot.GetBaseSpeed();
    }

    public string GetCry()
    {
        return "Sqoork!";
    }
}