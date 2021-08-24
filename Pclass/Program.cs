using System;
using Pclass.Partial;
namespace Pclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee(102);
            System.Console.WriteLine(employee.EmployeeID());
        }
    }
}
