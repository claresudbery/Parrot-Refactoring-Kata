using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
    public class AfricanParrot : Parrot
    {
        private readonly int _numberOfCoconuts;

        public AfricanParrot(int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }

        public override string GetCry()
        {
            return "Sqaark!";
        }

        private double GetLoadFactor()
        {
            return 9.0;
        }
    }
}
