using System;
using System.Threading;
using System.Threading.Tasks;
namespace TplProgram
{ 
    class Myapp
    {
        
        public static void LongTask()
        {
            Thread.Sleep(7000);
            Console.WriteLine("sleep 7000");
            
        }
        public static async void MyTask()
        {
            //Task task=new Task(new Action(LongTask));
             //task.Start();
             await Task.Run(new Action(LongTask));  //new thread generated
             System.Console.WriteLine("New thread Generated");  //
          
        }
        public static void Main()
        {
           MyTask();
           Console.WriteLine("I am main");
           Console.ReadLine();
        }
    }
}
