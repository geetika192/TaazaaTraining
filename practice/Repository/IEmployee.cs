using practice.Models;
using System.Collections.Generic;
namespace practice.Repository
{
    public interface IEmployee
    {
         void AddEmployee(Employee employee);
         void Delete(int Id);
         List<Employee> GetAll();
         void Update(Employee employee);
         Employee Find(int id);
    }
}