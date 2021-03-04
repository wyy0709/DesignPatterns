using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CarEx
{
    public class CarFactory
    {
        public ICar GetCar(CarBrand carBrand)
        {
            if (carBrand == CarBrand.BaoMa)
            {
                return new BaoMa();
            }
            else if (carBrand == CarBrand.BenChi)
            {
                return new BenChi();
            }
            return null;
        }
    }

    public enum CarBrand
    {
        Unknown = 0,
        BaoMa = 1,
        BenChi = 2
    }
}
