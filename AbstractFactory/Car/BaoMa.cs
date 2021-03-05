using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Car
{
    public class BaoMa
    {
        public void StartEngine(BaoMaCarFrame carFrame)
        {
            if (carFrame.engine == null)
            {
                Console.Write("组装前不能启动");
            }
            else
            {
                carFrame.engine.Start();
            }
        }
    }
}
