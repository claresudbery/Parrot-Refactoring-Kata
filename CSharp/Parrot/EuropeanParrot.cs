using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot(int numberOfCoconuts) 
            : base(numberOfCoconuts)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}
