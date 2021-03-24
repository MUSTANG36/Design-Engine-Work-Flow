using System;
using System.Collections.Generic;

namespace Design_Engine_Work_Flow
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            var engine = new WorkFlowEngine();

            workflow.Add(new Video());
            workflow.Add(new WebService());
            workflow.Add(new Email());

           
            engine.Run(workflow);

            Console.ReadLine();


        }


         
     }


 }

