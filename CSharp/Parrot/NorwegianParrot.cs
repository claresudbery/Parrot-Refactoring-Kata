using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class NorwegianParrot : Parrot
    {
        private readonly double _voltage;
        private readonly bool _isNailed;

        public NorwegianParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(numberOfCoconuts)
        {
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }
    }
}
