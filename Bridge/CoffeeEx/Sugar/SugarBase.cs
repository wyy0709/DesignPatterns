using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public abstract class SugarBase
    {
        //RegularSugar全糖，LessSugar四分之三，HalfSugar半糖，QuarterSugar四分之一，SugarFree无
        public abstract string SweetnessLevel { get; }

    }
}
