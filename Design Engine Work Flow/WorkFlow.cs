using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Engine_Work_Flow
{
    public class WorkFlow : IWorkFlow{

        private readonly List<ITask> _task;

        public WorkFlow() {
            _task = new List<ITask>();
        }

        public void Add(ITask task) {
            _task.Add(task);
        }
        public void Remove(ITask task) {
            _task.Remove(task);
        }

        //this way you return and ready only verison of your internal list
        //interface that that allows us to enumerate a list
        public IEnumerable<ITask> GetTasks()
        {
            return _task;
        }


    }
}
