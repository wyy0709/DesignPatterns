using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarEx
{
    public interface ICar
    {
        /// <summary>
        /// 组装
        /// </summary>
        void Assemble();

        /// <summary>
        /// 点火启动
        /// </summary>
        void StartEngine();
    }
}
