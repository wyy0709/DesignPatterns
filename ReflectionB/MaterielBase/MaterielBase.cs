using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionB.MaterielBase
{
    public abstract class MaterielBase
    {
        public abstract string Name { get; }
        public abstract int Index { get; }
        public abstract string Code { get; }
    }
}
