﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BaoMaCarFrame : ICarFrame
    {
        private IEngine engine;

        public void SetBattery(IBattery battery)
        {
            string batteryName = battery.GetName();
            Console.WriteLine(batteryName + "安装到BaoMa车架");
        }

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
            Console.WriteLine("引擎安装到BaoMa车架");
        }
    }
}
