using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Engine_Work_Flow
{

    public interface IWorkFlow
    {
      
        IEnumerable<ITask> GetTasks();
        public void Remove(ITask task);
        public void Add(ITask task);

    }
}
