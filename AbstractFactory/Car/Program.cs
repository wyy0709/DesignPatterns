using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> ConsoleResponseAction = new Action<string>(ConsoleResponse);

            while (true)
            {
                Console.Write("请输入汽车型号（0-退出）：");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }

                ConsoleResponseAction(input);

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void ConsoleResponse(string input)
        {
            if (input == "1")
            {
                BaoMaCarFrame carFrame = new BaoMaCarFrame();
                VARTA battery = new VARTA();
                BaoMaEngine engine = new BaoMaEngine();

                carFrame.SetEngine(engine);
                carFrame.SetBattery(battery);

                Console.WriteLine("BaoMa组装完毕");

                BaoMa car = new BaoMa();
                car.StartEngine(carFrame);
            }
            else
            {
                Console.Write("查无此品牌");
            }

        }
    }
}
