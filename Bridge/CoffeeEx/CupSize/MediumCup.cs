using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public class MediumCup : CupBase
    {
        public override string CupName
        {
            get
            {
                return "中杯";
            }
        }
    }
}
