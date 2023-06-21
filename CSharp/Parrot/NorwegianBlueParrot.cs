namespace Parrot;

public class NorwegianBlueParrot : Parrot
{
    private readonly bool _isNailed;

    public NorwegianBlueParrot(
        int numberOfCoconuts, 
        double voltage, 
        bool isNailed) 
        : base(ParrotTypeEnum.NORWEGIAN_BLUE, numberOfCoconuts, voltage, isNailed)
    {
        _isNailed = isNailed;
    }

    public override double GetSpeed()
    {
        return _isNailed ? 0 : GetBaseSpeed(_voltage);
    }
}