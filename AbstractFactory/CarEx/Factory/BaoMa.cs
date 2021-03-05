using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BaoMa : ICar
    {
        private IEngine engine;

        public void Assemble()
        {
            IAbstractFactory abstractFactory = new BaoMaAbstractFactory();
            ICarFrame carFrame = abstractFactory.GetCarFrame();
            this.engine = abstractFactory.GetEngine();
            IBattery battery = abstractFactory.GetBattery();

            carFrame.SetEngine(this.engine);
            carFrame.SetBattery(battery);

            Console.WriteLine("宝马组装完毕");
        }

        public void StartEngine()
        {
            if (this.engine == null)
            {
                Console.Write("组装前不能启动");
            }
            else
            {
                Console.Write("宝马已启动");
            }
        }
    }
}
