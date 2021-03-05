using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CarEx
{
    public class BaoMa: ICar
    {
        public void StartEngine()
        {
            Console.Write("BaoMa已启动");
        }
    }
}
