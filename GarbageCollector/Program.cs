//difference btw dispose and finalyze
using System;
using GarbageCollector;
namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {   //we are difining the scope of object using block.Achieves Garbage Collection
            using(It it=new It())
            {
                 it.DatabaseCollect(); //now the function is called , got the value still resources are running so why not cleanup the resources just after consuming 
                                       //this is where the garbage collection comes into picture.
            }   //At this point dispose function will be called explicitly
            Console.WriteLine("End of Program");
        }
        
    }
}
