﻿using System;

namespace Parrot
{
    public class NorwegianParrot : Parrot
    {
        private readonly double _voltage;
        private readonly bool _isNailed;

        public NorwegianParrot(double voltage, bool isNailed)
        {
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }

        public override string GetCry()
        {
            return _voltage > 0 ? "Bzzzzzz" : "...";
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }
    }
}
