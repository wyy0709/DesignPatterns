using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CarEx
{
    public class DaZhong : ICar
    {
        public void StartEngine()
        {
            Console.Write("大众已启动");
        }
    }
}
