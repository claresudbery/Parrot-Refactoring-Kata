using System;
using System.Collections.Generic;

namespace Parrot
{
    public class Parrot : IParrot
    {
        private readonly bool _isNailed;
        private readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        private readonly double _voltage;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
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
                    return new EuropeanParrot(type, numberOfCoconuts, voltage, isNailed);
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(type, numberOfCoconuts, voltage, isNailed);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot(type, numberOfCoconuts, voltage, isNailed);
            }

            return new Parrot(type, numberOfCoconuts, voltage, isNailed);
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public double GetBaseSpeed()
        {
            return 12.0;
        }

        public string GetCry()
        {
            string value;
            switch (_type)
            {
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