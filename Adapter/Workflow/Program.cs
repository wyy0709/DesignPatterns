using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Workflow
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> ConsoleResponseAction = new Action<string>(ConsoleResponse);

            while (true)
            {
                Console.Write("请输入要使用的Workflow版本（3 or 4）：");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }

                ConsoleResponseAction(input);

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void ConsoleResponse(string input)
        {
            if (input == "3" || input == "4")
            {
                switch (input)
                {
                    case "3":
                        WF3Core wf3 = new WF3Core();
                        wf3.StartWorkflow();
                        wf3.TerminateWorkflow();
                        break;
                    case "4":
                        IWorkflow wf4 = new WF4Core();
                        wf4.Start();
                        wf4.Terminate("haha~");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.Write("输入错误");
            }
        }
    }
}
