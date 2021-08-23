using System;
using Miscellaneous.IT;

namespace Miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mohan=new Taazaa(101,1000);
            var sohan=new Taazaa(102,1000);

            var sal = Mohan.EmployeeSalary();
            Console.WriteLine(sal);

            var sal2 = Mohan.EmployeeSalary();
            Console.WriteLine(sal2);

            var caf=Taazaa.Coffeehouse();
            Console.WriteLine(caf);

            Console.WriteLine(Taazaa.Coffeehouse());


        }
    }
}
