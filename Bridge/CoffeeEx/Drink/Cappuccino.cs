using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public class Cappuccino : DrinkBase
    {
        public override string DrinkName
        {
            get
            {
                return "卡布奇诺";
            }
        }

    }
}
