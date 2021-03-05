using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public interface ICarFrame
    {
        void SetEngine(IEngine engine);
        void SetBattery(IBattery battery);
    }
}
