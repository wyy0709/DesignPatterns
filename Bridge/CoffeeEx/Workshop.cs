using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    public class Workshop
    {
        public void Fill(DrinkBase drink, CupBase cup, SugarBase sugar)
        {
            Console.WriteLine("装好了一【" + cup.CupName + "】【" + sugar.SweetnessLevel + "】的【" + drink.DrinkName + "】");
        }
    }
}
