using System;
using Geetika;
delegate void AdditionDelagate(int n,int n1);
namespace delegates
{
    class Program
    {
        public static void Main()
        {
          AdditionDelagate additionDelegate =new AdditionDelagate(Mathh.Addition);
          additionDelegate.Invoke(4,5); 
        }
    }
}
