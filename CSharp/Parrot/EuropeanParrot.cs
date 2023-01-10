using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed) 
            : base(ParrotTypeEnum.EUROPEAN, numberOfCoconuts, voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}
