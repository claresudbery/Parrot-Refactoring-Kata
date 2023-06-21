using System;

namespace Parrot
{
    public class Parrot
    {
        protected readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        protected readonly double _voltage;

        protected Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
        }

        public static Parrot CreateInstance(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.AFRICAN: return new AfricanParrot(
                    numberOfCoconuts, 
                    voltage, 
                    isNailed);
                case ParrotTypeEnum.EUROPEAN: return new EuropeanParrot(
                    numberOfCoconuts, 
                    voltage, 
                    isNailed);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot(numberOfCoconuts,
                        voltage,
                        isNailed);
            }

            return new Parrot(type, numberOfCoconuts, voltage, isNailed);
        }

        public virtual double GetSpeed()
        {
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