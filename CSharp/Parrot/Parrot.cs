using System;
using System.Collections.Generic;

namespace Parrot
{
    public abstract class Parrot
    {
        private static ParrotTypeEnum _type;
        private static double _voltage;

        public static Parrot CreateInstance(
            ParrotTypeEnum type, 
            int numberOfCoconuts, 
            double voltage, 
            bool isNailed)
        {
            _voltage = voltage;
            _type = type;
            
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

        public string GetCry()
        {
            string value;
            
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    value = "Sqoork!";
                    break;
                case ParrotTypeEnum.AFRICAN:
                    value = "Sqaark!";
                    break;
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    value = _voltage > 0 ? "Bzzzzzz" : "...";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return value;
        }
    }
}