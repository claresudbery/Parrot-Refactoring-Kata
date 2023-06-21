using System;
using System.Collections.Generic;

namespace Parrot
{
    public abstract class Parrot
    {
        public static Parrot CreateInstance(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.European:
                    return new EuropeanParrot();
                case ParrotTypeEnum.African:
                    return new AfricanParrot(numberOfCoconuts);
                case ParrotTypeEnum.NorwegianBlue:
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