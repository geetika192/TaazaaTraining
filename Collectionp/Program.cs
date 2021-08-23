using System;
using Collectionp.EmployeeList;
using Collectionp.Models;
namespace Collectionp
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee emp= new Employee();
            emp.EmpId=101;
            emp.EmpName="Geetika";
            emp.Empsalary=10000;

            Employee emp1= new Employee();
            emp1.EmpId=102;
            emp1.EmpName="Shukla";
            emp1.Empsalary=2000;



           // EmployeeList employeeList=new EmployeeList();
           EmpList obj1= new EmpList();
           obj1.AddEmployee(emp);
           obj1.AddEmployee(emp1);

          var temp= obj1.EmpDisplayList();
          foreach(var i in temp)
          {
              Console.WriteLine(i.EmpId+""+i.EmpName+""+i.Empsalary);
          }
            
             Employee empsearch= obj1.EmpSearch(111);
             Console.WriteLine(empsearch.EmpId+""+empsearch.EmpName+""+empsearch.Empsalary);
        }
    }
}
