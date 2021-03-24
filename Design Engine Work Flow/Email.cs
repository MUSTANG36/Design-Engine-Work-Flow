using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Engine_Work_Flow
{
    public class Email : ITask
    {
        public void Execute() {
            Console.WriteLine("Processing");
        }
    }
}
