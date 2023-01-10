using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class AfricanParrot : Parrot
    {
        public AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(ParrotTypeEnum.AFRICAN, numberOfCoconuts, voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }
}
