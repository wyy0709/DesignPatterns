using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllPath = string.Format("{0}\\Reflection.Unknown.dll", Environment.CurrentDirectory);

            var assembly = Assembly.LoadFrom(dllPath);

            var types = assembly.GetTypes();

            ShowClasses(types);

            var tagetType = types.First(t => t.Name == "Best");

            var methods = tagetType.GetMethods();

            ShowMethods(methods);

            var targetMethod = methods.First(m => m.Name == "GetSecretSignal");

            var instance = assembly.CreateInstance(tagetType.FullName);
            var result = targetMethod.Invoke(instance, null);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static void ShowClasses(Type[] types)
        {
            Console.WriteLine("All types in dll:");
            foreach (var t in types)
            {
                Console.WriteLine("\t" + t.ToString());
            }
            Console.WriteLine();
        }

        static void ShowMethods(MethodInfo[] methods)
        {
            Console.WriteLine("All methods in 'Best' class:");
            foreach (var m in methods)
            {
                Console.WriteLine("\t" + m.ToString());
            }
            Console.WriteLine();
        }


    }
}
