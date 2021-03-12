using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string drinkType;
                while (true)
                {
                    Console.Write("请选择饮品种类（1-卡布奇诺；2-拿铁；3-玛奇朵；）：");
                    drinkType = Console.ReadLine();

                    if (drinkType == "1" || drinkType == "2" || drinkType == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                string cupSize;
                while (true)
                {
                    Console.Write("请选择规格（1-小杯；2-中杯；3-大杯；）：");
                    cupSize = Console.ReadLine();

                    if (cupSize == "1" || cupSize == "2" || cupSize == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }


                if (drinkType == "1" && cupSize == "1")
                {
                    new SmallCappuccino().Fill();
                }
                else if (drinkType == "1" && cupSize == "2")
                {
                    new MediumCappuccino().Fill();
                }
                else if (drinkType == "1" && cupSize == "3")
                {
                    new LargeCappuccino().Fill();
                }
                else if (drinkType == "2" && cupSize == "1")
                {
                    new SmallLatte().Fill();
                }
                else if (drinkType == "2" && cupSize == "2")
                {
                    new MediumLatte().Fill();
                }
                else if (drinkType == "2" && cupSize == "3")
                {
                    new LargeLatte().Fill();
                }
                else if (drinkType == "3" && cupSize == "1")
                {
                    new SmallMacchiato().Fill();
                }
                else if (drinkType == "3" && cupSize == "2")
                {
                    new MediumMacchiato().Fill();
                }
                else if (drinkType == "3" && cupSize == "3")
                {
                    new LargeMacchiato().Fill();
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
