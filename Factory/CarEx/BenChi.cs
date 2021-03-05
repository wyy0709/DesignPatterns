using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CarEx
{
    public class BenChi : ICar
    {
        public void StartEngine()
        {
            Console.Write("BenChi已启动");
        }
    }
}
