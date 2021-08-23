using System.Collections.Generic;
using Collectionp.Models;
namespace Collectionp.EmployeeList
{
    public interface IEmployee
    {
         void AddEmployee(Employee obj);
         List<Employee> EmpDisplayList();
    }
}