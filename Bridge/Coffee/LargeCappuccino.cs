using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Coffee
{
    public class LargeCappuccino : Drink
    {
        public override string CupSize
        {
            get
            {
                return "大杯";
            }
        }

        public override string DrinkName
        {
            get
            {
                return "卡布奇诺";
            }
        }
    }
}
