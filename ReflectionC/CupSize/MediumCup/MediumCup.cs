
using ReflectionC.MaterielBase;
using System;

namespace ReflectionC.MediumCup
{
    //[Material(IsActivated = true)]
    public class MediumCup : CupBase.CupBase
    {
        public override string Code
        {
            get
            {
                return "2";
            }
        }

        public override decimal Cost
        {
            get
            {
                return (decimal)0.2;
            }
        }

        public override int Index
        {
            get
            {
                return 2;
            }
        }

        public override string Name
        {
            get
            {
                return "中杯";
            }
        }

    }
}
