namespace Parrot;

public class NorwegianBlueParrot : IParrot
{
    private readonly Parrot _parrot;

    public NorwegianBlueParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _parrot = new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public double GetSpeed()
    {
        return _parrot.GetSpeed();
    }

    public string GetCry()
    {
        return _parrot.GetCry();
    }
}