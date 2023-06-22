using System;
using System.Collections.Generic;

namespace Parrot
{
    public class Parrot
    {
        public Parrot(ParrotTypeEnum type)
        {
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
                    return new EuropeanParrot(type);
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(type, numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot(type, voltage, isNailed);
                default: 
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}