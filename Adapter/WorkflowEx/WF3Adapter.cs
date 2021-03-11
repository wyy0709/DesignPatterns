using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WorkflowEx
{
    public class WF3Adapter : IWorkflow
    {
        private WF3Core wf3 = new WF3Core();

        public void Resume()
        {
            wf3.ResumeWorkflow();
        }

        public void Start()
        {
            wf3.StartWorkflow();
        }

        public void Suspend()
        {
            wf3.SuspendWorkflow();
        }

        public void Terminate(string reason)
        {
            wf3.TerminateWorkflow();
        }
    }
}
