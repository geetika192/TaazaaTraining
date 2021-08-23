using System;
using AdvanceDelegate.Arithematic;
delegate void ArthematicDelegate(double d1 , double d2);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
                            // Using Delegate

            ArthematicDelegate Aobj=new ArthematicDelegate(ArthematicOperation.Addition);
            Aobj.Invoke(3.5,6.8);
            /* Aobj+=ArthematicOperation.Multiply;
            Aobj.Invoke(2,3);  */
 
                              // Annonymous Method

            ArthematicDelegate mycal=delegate(double d1 ,double d2)
            {
                System.Console.WriteLine(d1*d2);
            };

             mycal(10,20); 

                               //Lambda Function

            ArthematicDelegate mycal1 =(double d1 , double d2) =>
              {
                System.Console.WriteLine(d1*d2);
              };
               mycal(10,20);
        }
    }
}
