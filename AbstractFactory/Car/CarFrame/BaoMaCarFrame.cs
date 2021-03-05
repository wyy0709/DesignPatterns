using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Car
{
    public class BaoMaCarFrame 
    {
        public BaoMaEngine engine;

        public void SetBattery(VARTA battery)
        {
            string batteryName = battery.GetName();
            Console.WriteLine(batteryName + "安装到BaoMa车架");
        }

        public void SetEngine(BaoMaEngine engine)
        {
            this.engine = engine;
            Console.WriteLine("引擎安装到BaoMa车架");
        }
    }
}
