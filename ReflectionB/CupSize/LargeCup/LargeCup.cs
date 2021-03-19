

using System;

namespace ReflectionB.LargeCup
{
    public class LargeCup : CupBase.CupBase
    {
        public override string Code
        {
            get
            {
                return "1";
            }
        }

        public override decimal Cost
        {
            get
            {
                return (decimal)0.3;
            }
        }

        public override int Index
        {
            get
            {
                return 1;
            }
        }

        public override string Name
        {
            get
            {
                return "大杯";
            }
        }


    }
}
