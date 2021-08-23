using System;
using day4.Night;
using day4.Person_son;
namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
           INight obj=new Person();
           int temp=obj.study(); 
           Console.WriteLine(temp);
        }
    }
}
