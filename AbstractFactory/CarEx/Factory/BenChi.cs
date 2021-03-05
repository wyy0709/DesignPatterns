using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public class BenChi : ICar
    {
        private IEngine engine;

        public void Assemble()
        {
            IAbstractFactory abstractFactory = new BenChiAbstractFactory();
            ICarFrame carFrame = abstractFactory.GetCarFrame();
            this.engine = abstractFactory.GetEngine();
            IBattery battery = abstractFactory.GetBattery();

            carFrame.SetBattery(battery);
            carFrame.SetEngine(this.engine);

            Console.WriteLine("BenChi组装完毕");
        }

        public void StartEngine()
        {
            if (this.engine == null)
            {
                Console.Write("组装前不能启动");
            }
            else
            {
                this.engine.Start();
            }
        }
    }
}
