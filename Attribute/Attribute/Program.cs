using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute.Interceptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            var result = calc.Add(2, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
