using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public interface IAbstractFactory
    {
        ICarFrame GetCarFrame();
        IEngine GetEngine();
        IBattery GetBattery();
    }
}
