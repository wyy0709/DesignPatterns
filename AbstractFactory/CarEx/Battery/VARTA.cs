using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class VARTA : IBattery
    {
        public string GetName()
        {
            return "VARTA电瓶";
        }
    }
}
