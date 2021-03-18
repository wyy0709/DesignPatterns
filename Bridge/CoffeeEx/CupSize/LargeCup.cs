using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public class LargeCup : CupBase
    {
        public override string CupName
        {
            get
            {
                return "大杯";
            }
        }
    }
}
