
using ReflectionC.MaterielBase;
using System;

namespace ReflectionC.RegularSugar
{
    [Material(IsActivated = true)]
    public class RegularSugar : SugarBase.SugarBase
    {
        public override string Code
        {
            get
            {
                return "1";
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
                return "全糖";
            }
        }
    }
}

