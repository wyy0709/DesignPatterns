
using System;

namespace ReflectionB.Cappuccino
{
    public class Cappuccino : DrinkBase.DrinkBase
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
                return "Cappuccino";
            }
        }
    }
}
