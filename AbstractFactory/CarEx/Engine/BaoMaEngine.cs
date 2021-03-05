﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BaoMaEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("BaoMa已启动");
        }
    }
}
