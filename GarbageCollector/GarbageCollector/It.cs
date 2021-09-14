using System;
namespace GarbageCollector
{
    public class It:IDisposable
    {
        public void DatabaseCollect() //to connect to the database we need so many resources
        {
          System.Console.WriteLine("Let me write a code to connect to database");
        }

        public void Dispose()
        {
            System.Console.WriteLine("Destructor is working now!!");
        }

        /* ~It()  //finalyze act as a destructor
        {
          System.Console.WriteLine("Destructor is working now!!");
        } */
    }
}