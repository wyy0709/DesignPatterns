using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BaoMaAbstractFactory : IAbstractFactory
    {
        public ICarFrame GetCarFrame()
        {
            return new BaoMaCarFrame();
        }

        public IEngine GetEngine()
        {
            return new BaoMaEngine();
        }
        public IBattery GetBattery()
        {
            return new VARTA();
        }

    }
}
