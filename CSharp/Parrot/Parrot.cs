using System;

namespace Parrot
{
    public abstract class Parrot
    {
        protected readonly int NumberOfCoconuts;

        protected Parrot(int numberOfCoconuts)
        {
            NumberOfCoconuts = numberOfCoconuts;
        }

        public static Parrot CreateInstance(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {

            switch (type)
            {
                case ParrotTypeEnum.European:
                    return new EuropeanParrot(numberOfCoconuts);
                case ParrotTypeEnum.African:
                    return new AfricanParrot(numberOfCoconuts, voltage, isNailed);
                case ParrotTypeEnum.NorwegianBlue:
                    return new NorwegianParrot(numberOfCoconuts, voltage, isNailed);
                default:
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }

        public abstract double GetSpeed();
        
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