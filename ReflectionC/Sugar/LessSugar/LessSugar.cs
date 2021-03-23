using ReflectionC.MaterielBase;
using System;

namespace ReflectionC.LessSugar
{
    [Material(IsActivated = true)]
    public class LessSugar : SugarBase.SugarBase
    {
        public override string Code
        {
            get
            {
                return "666";
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
                return "少糖";
            }
        }
    }
}

