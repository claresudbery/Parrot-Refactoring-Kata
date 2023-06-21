using System;

namespace Parrot
{
    public abstract class Parrot
    {
        public static Parrot CreateInstance(
            ParrotTypeEnum type, 
            int numberOfCoconuts, 
            double voltage, 
            bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianParrot(voltage, isNailed);
                default:
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }

        public abstract double GetSpeed();

        protected double GetBaseSpeed()
        {
            return 12.0;
        }

        public abstract string GetCry();
    }
}