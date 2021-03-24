using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Engine_Work_Flow
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {

            foreach (ITask i in workFlow.GetTasks())
            {
                try
                {
                    i.Execute();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
