using System;
using System.Collections.Generic;

namespace Parrot
{
    public class Parrot
    {
        private readonly ParrotTypeEnum _type;

        private Parrot(ParrotTypeEnum type)
        {
            _type = type;
        }

        public static IParrot CreateInstance(
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
                    return new NorwegianBlueParrot(voltage, isNailed);
                default: 
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static double GetBaseSpeed()
        {
            return 12.0;
        }

        public string GetCry()
        {
            string value;
            switch (_type)
            {
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return value;
        }
    }
}