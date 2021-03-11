using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WorkflowEx
{
    class Program
    {
        private static IUnityContainer container;

        static void Main(string[] args)
        {
            RegisterContainer();

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

        private static void RegisterContainer()
        {
            container = new UnityContainer();
            UnityConfigurationSection config = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            config.Configure(container, "Workflow");
        }

        static void ConsoleResponse(string input)
        {
            if (input == "3" || input == "4")
            {
                IWorkflow wf = container.Resolve<IWorkflow>("WF"+ input);
                wf.Start();
                wf.Terminate("haha~");
            }
            else
            {
                Console.WriteLine("输入错误");
            }
        }
    }
}
