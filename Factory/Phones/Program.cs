using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入汽车型号：");
            string carBrand = Console.ReadLine();
            if (carBrand == "1")
            {
                BaoMa car = new BaoMa();
                car.StartEngine();
            }
            else if (carBrand == "2")
            {
                BenChi car = new BenChi();
                car.StartEngine();
            }
            else
            {
                Console.Write("查无此品牌");
            }
            Console.ReadKey();
        }
    }
}
