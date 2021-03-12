using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Coffee
{
    public class MediumLatte : Drink
    {
        public override string CupSize
        {
            get
            {
                return "中杯";
            }
        }

        public override string DrinkName
        {
            get
            {
                return "拿铁";
            }
        }
    }
}
