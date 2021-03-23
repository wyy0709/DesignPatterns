using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionC.MaterielBase
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class MaterialAttribute : Attribute
    {
        public bool IsActivated { get; set; }
    }


}
