using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class NorwegianParrot : Parrot
    {
        public NorwegianParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(ParrotTypeEnum.NORWEGIAN_BLUE, numberOfCoconuts, voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }
    }
}
