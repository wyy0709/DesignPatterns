using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute.Interceptor
{
    [Aop]
    public class Calc : ContextBoundObject
    {
        public Calc()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
