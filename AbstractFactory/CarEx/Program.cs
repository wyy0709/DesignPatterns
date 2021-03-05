using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
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
            int carBrand = (int)CarBrand.Unknown;
            if (int.TryParse(input, out carBrand))
            {
                CarFactory carFactory = new CarFactory();
                ICar car = carFactory.GetCar((CarBrand)carBrand);
                if (car != null)
                {
                    car.Assemble();
                    car.StartEngine();
                }
                else
                {
                    Console.Write("查无此品牌");
                }
            }
            else
            {
                Console.Write("输入错误");
            }
        }
    }
}
