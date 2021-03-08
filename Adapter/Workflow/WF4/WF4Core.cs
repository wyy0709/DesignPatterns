using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Workflow
{
    public class WF4Core : IWorkflow
    {
        public void Start()
        {
            Console.WriteLine("Workflow 4 已启动");
        }

        public void Suspend()
        {
            Console.WriteLine("Workflow 4 已暂停");
        }

        public void Resume()
        {
            Console.WriteLine("Workflow 4 已恢复");
        }

        public void Terminate(string reason)
        {
            string str = "Workflow 4 已中止";
            if (!string.IsNullOrWhiteSpace(reason)) {
                str += "，理由："+ reason;
            }
            Console.WriteLine(str);
        }
    }
}
