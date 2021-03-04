using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CarEx
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入汽车型号（0-退出）：");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                int carBrand = (int)CarBrand.Unknown;
                if (int.TryParse(input, out carBrand))
                {
                    CarFactory carFactory = new CarFactory();
                    ICar car = carFactory.GetCar((CarBrand)carBrand);
                    if (car != null)
                    {
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
                Console.WriteLine();
                Console.WriteLine();
            }
        }


    }
}
