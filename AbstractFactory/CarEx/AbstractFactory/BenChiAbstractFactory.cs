using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BenChiAbstractFactory : IAbstractFactory
    {
        public ICarFrame GetCarFrame()
        {
            return new BenChiCarFrame();
        }

        public IEngine GetEngine()
        {
            return new BenChiEngine();
        }

        public IBattery GetBattery()
        {
            return new VARTA();
        }
    }
}
