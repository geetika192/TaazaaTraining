using System;
using StaticPoly.Persons;
namespace StaticPoly
{
    class Program
    {
        static void Main(string[] args)
        {
           Person person=new Person();
           System.Console.WriteLine(person.Walk(12));  //association of object with method
           System.Console.WriteLine(person.Walk("12 km"));
        }
    }
}
