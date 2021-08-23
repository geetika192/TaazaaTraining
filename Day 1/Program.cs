using System;
using mlab; //using is a keyword to include the namespace(mlab is a namespace) 
namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
          calculus obj=new calculus();
          string temp=obj.limits();
          Console.WriteLine(temp);   
        }

    }
}
