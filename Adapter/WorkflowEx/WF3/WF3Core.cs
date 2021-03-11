using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WorkflowEx
{
    /// <summary>
    /// 本代码文件不允许修改
    /// </summary>
    public class WF3Core
    {
        public void StartWorkflow()
        {
            Console.WriteLine("Workflow 3 已启动");
        }

        public void SuspendWorkflow()
        {
            Console.WriteLine("Workflow 3 已暂停");
        }

        public void ResumeWorkflow()
        {
            Console.WriteLine("Workflow 3 已恢复");
        }

        public void TerminateWorkflow()
        {
            Console.WriteLine("Workflow 3 已中止");
        }
    }
}
