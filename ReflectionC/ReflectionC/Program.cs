using ReflectionC.MaterielBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = string.Format("{0}", Environment.CurrentDirectory);
            string[] filePaths = Directory.GetFiles(appPath, "*.dll", SearchOption.AllDirectories);

            var drinkInstanceDic = new Dictionary<string, DrinkBase.DrinkBase>();
            var cupInstanceDic = new Dictionary<string, CupBase.CupBase>();
            var sugarInstanceDic = new Dictionary<string, SugarBase.SugarBase>();

            foreach (var path in filePaths)
            {
                var assembly = Assembly.LoadFrom(path);
                var allTypes = assembly.GetTypes();

                foreach (var t in allTypes)
                {
                    var attribute = t.GetCustomAttribute<MaterialAttribute>();
                    if (attribute == null || !attribute.IsActivated)
                    {
                        continue;
                    }
                    if (t.IsSubclassOf(typeof(DrinkBase.DrinkBase)))
                    {
                        var instance = (DrinkBase.DrinkBase)assembly.CreateInstance(t.FullName);
                        drinkInstanceDic.Add(instance.Code, instance);
                    }
                    else if (t.IsSubclassOf(typeof(CupBase.CupBase)))
                    {
                        var instance = (CupBase.CupBase)assembly.CreateInstance(t.FullName);
                        cupInstanceDic.Add(instance.Code, instance);
                    }
                    else if (t.IsSubclassOf(typeof(SugarBase.SugarBase)))
                    {
                        var instance = (SugarBase.SugarBase)assembly.CreateInstance(t.FullName);
                        sugarInstanceDic.Add(instance.Code, instance);
                    }
                }
            }


            StartWork(drinkInstanceDic, cupInstanceDic, sugarInstanceDic);

        }

        static void StartWork(Dictionary<string, DrinkBase.DrinkBase> drinkDic, Dictionary<string, CupBase.CupBase> cupDic, Dictionary<string, SugarBase.SugarBase> sugarDic)
        {
            while (true)
            {
                DrinkBase.DrinkBase drinkType;
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
                CupBase.CupBase cupSize;
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
                SugarBase.SugarBase sugar;
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

        static string CreateTips<T>(Dictionary<string, T> dic) where T : MaterielBase.MaterielBase
        {
            dic = dic.OrderBy(x => x.Value.Index).ToDictionary(x => x.Key, x => x.Value);
            string tip = "";
            foreach (var key in dic.Keys)
            {
                tip += string.Format("{0}-{1}; ", key, dic[key].Name);
            }
            return tip;
        }

        static void Fill(DrinkBase.DrinkBase drink, CupBase.CupBase cup, SugarBase.SugarBase sugar)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("装好了一【{0}({3})】【{1}】的【{2}】", cup.Name, sugar.Name, drink.Name, cup.Cost));
        }
    }
}