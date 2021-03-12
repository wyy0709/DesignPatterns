using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Coffee
{
    public abstract class Drink
    {
        public abstract string CupSize { get; }
        public abstract string DrinkName { get; }

        public void Fill()
        {
            Console.WriteLine("装好了一【" + this.CupSize + "】的【" + this.DrinkName + "】");
        }
    }
}
