using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BenChiEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("奔驰已启动");
        }
    }
}
