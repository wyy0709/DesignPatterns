using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Workflow
{
    /// <summary>
    /// 本代码文件不允许修改
    /// </summary>
    public interface IWorkflow
    {
        void Start();


        void Suspend();


        void Resume();


        void Terminate(string reason);

    }
}
