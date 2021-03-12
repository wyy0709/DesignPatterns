﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Coffee
{
    public class SmallMacchiato : Drink
    {
        public override string CupSize
        {
            get
            {
                return "小杯";
            }
        }

        public override string DrinkName
        {
            get
            {
                return "玛奇朵";
            }
        }
    }
}