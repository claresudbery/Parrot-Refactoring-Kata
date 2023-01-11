using System;

namespace Parrot
{
    public class Parrot
    {
        protected readonly bool _isNailed;
        protected readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        protected readonly double _voltage;

        protected Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public static Parrot CreateInstance(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {

            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot(numberOfCoconuts, voltage, isNailed);
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts, voltage, isNailed);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianParrot(numberOfCoconuts, voltage, isNailed);
                default:
                    return new Parrot(type, numberOfCoconuts, voltage, isNailed);
            }
        }

        public virtual double GetSpeed()
        {
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return GetBaseSpeed();
                case ParrotTypeEnum.AFRICAN:
                    return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return _isNailed ? 0 : GetBaseSpeed(_voltage);
            }

            throw new Exception("Should be unreachable");
        }

        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        protected double GetLoadFactor()
        {
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}