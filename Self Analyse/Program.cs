using System;
using selfAnalyase.Models;
namespace selfAnalyase
{
    class Program
    {
        static void Main(string[] args)
        {
            var Geetika=new Company(101,2000);
            var Deepti =new Company(102,1000);

            var sal=Geetika.EmployeeSalary();
            Console.WriteLine(sal);
            var sal2=Deepti.EmployeeSalary();
            Console.WriteLine(sal2);

            Console.WriteLine(Company.Coffeehouse());
            
        }
    }
}
