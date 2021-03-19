using ReflectionB.MaterielBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = string.Format("{0}", Environment.CurrentDirectory);
            string[] filePaths = Directory.GetFiles(appPath, "*.dll", SearchOption.AllDirectories);

            var cupInstanceDic = new Dictionary<string, MaterielBase.MaterielBase>();
            var drinkInstanceDic = new Dictionary<string, MaterielBase.MaterielBase>();
            var sugarInstanceDic = new Dictionary<string, MaterielBase.MaterielBase>();

            foreach (var path in filePaths)
            {
                var assembly = Assembly.LoadFrom(path);
                var allTypes = assembly.GetTypes();

                foreach (var t in allTypes)
                {
                    if (t.IsSubclassOf(typeof(CupBase.CupBase)))
                    {
                        var instance = (CupBase.CupBase)assembly.CreateInstance(t.FullName);
                        cupInstanceDic.Add(instance.Code, instance);
                    }
                    else if (t.IsSubclassOf(typeof(DrinkBase.DrinkBase)))
                    {
                        var instance = (DrinkBase.DrinkBase)assembly.CreateInstance(t.FullName);
                        drinkInstanceDic.Add(instance.Code, instance);
                    }
                    else if (t.IsSubclassOf(typeof(SugarBase.SugarBase)))
                    {
                        var instance = (SugarBase.SugarBase)assembly.CreateInstance(t.FullName);
                        sugarInstanceDic.Add(instance.Code, instance);
                    }
                }
            }


            StartWork(cupInstanceDic, drinkInstanceDic, sugarInstanceDic);

        }

        static void StartWork(Dictionary<string, MaterielBase.MaterielBase> cupDic, Dictionary<string, MaterielBase.MaterielBase> drinkDic, Dictionary<string, MaterielBase.MaterielBase> sugarDic)
        {
            while (true)
            {
                MaterielBase.MaterielBase drinkType;
                while (true)
                {
                    Console.Write(string.Format("请选择饮品种类（{0}）：", CreateTips(drinkDic)));
                    string input = Console.ReadLine();

                    if (drinkDic.ContainsKey(input))
                    {
                        drinkType = drinkDic[input];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                Console.WriteLine();
                MaterielBase.MaterielBase cupSize;
                while (true)
                {
                    Console.Write(string.Format("请选择规格（{0}）：", CreateTips(cupDic)));
                    string input = Console.ReadLine();

                    if (cupDic.ContainsKey(input))
                    {
                        cupSize = cupDic[input];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }

                Console.WriteLine();
                MaterielBase.MaterielBase sugar;
                while (true)
                {
                    Console.Write(string.Format("请选择糖量（{0}）：", CreateTips(sugarDic)));
                    string input = Console.ReadLine();

                    if (sugarDic.ContainsKey(input))
                    {
                        sugar = sugarDic[input];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }
                
                Fill(drinkType, cupSize, sugar);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }


        }

        static string CreateTips(Dictionary<string, MaterielBase.MaterielBase> dic)
        {
            dic = dic.OrderBy(x => x.Value.Index).ToDictionary(x => x.Key, x => x.Value);
            string tip = "";
            foreach (var key in dic.Keys)
            {
                tip += string.Format("{0}-{1}; ", key, dic[key].Name);
            }
            return tip;
        }

        static void Fill(MaterielBase.MaterielBase drink, MaterielBase.MaterielBase cup, MaterielBase.MaterielBase sugar)
        {
            Console.WriteLine();
            Console.WriteLine("装好了一【" + cup.Name + "】【" + sugar.Name + "】的【" + drink.Name + "】");
        }
    }
}
