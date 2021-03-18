using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public class RegularSugar : SugarBase
    {
        public override string SweetnessLevel
        {
            get
            {
                return "全糖";
            }
        }
    }
}
