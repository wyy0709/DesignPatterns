using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DrinkBase drinkType;
                while (true)
                {
                    Console.Write("请选择饮品种类（1-卡布奇诺；2-拿铁；3-玛奇朵；）：");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        drinkType = new Cappuccino();
                        break;
                    }
                    else if (input == "2")
                    {
                        drinkType = new Latte();
                        break;
                    }
                    else if (input == "3")
                    {
                        drinkType = new Macchiato();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                CupBase cupSize;
                while (true)
                {
                    Console.Write("请选择规格（1-小杯；2-中杯；3-大杯；）：");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        cupSize = new SmallCup();
                        break;
                    }
                    else if (input == "2")
                    {
                        cupSize = new MediumCup();
                        break;
                    }
                    else if (input == "3")
                    {
                        cupSize = new LargeCup();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                SugarBase sugar;
                while (true)
                {
                    Console.Write("请选择糖量（1-少糖；2-全糖；）：");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        sugar = new LessSugar();
                        break;
                    }
                    else if (input == "2")
                    {
                        sugar = new RegularSugar();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                new Workshop().Fill(drinkType, cupSize ,sugar);

                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
