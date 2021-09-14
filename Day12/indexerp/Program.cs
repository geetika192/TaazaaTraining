using System;
using indexerp.Employee;
namespace indexerp
{
    class Program
    {
        static void Main(string[] args)
        {
          Employees employee=new Employees();
         employee.Empid=101; // at this point set will be called.. 
        System.Console.WriteLine(employee.Empid);
           

        }
    }
}
