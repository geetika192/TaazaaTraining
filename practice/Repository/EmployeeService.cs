using practice.Models;
using System.Linq;
using System.Collections.Generic;
namespace practice.Repository
{
    public class EmployeeService: IEmployee
    {
        List<Employee> emp=new List<Employee>();
         public void AddEmployee(Employee employee)
         {
             emp.Add(employee);
         }
         public void Delete(int Id)
         {
           var EmployeeToDelete=emp.Where(ctr=>ctr.EmpId==Id).SingleOrDefault();  
           if(EmployeeToDelete!=null)
           {
               emp.Remove(EmployeeToDelete);
           }
         }
         
         public List<Employee> GetAll()
         {
            return emp;
         }

         public void Update(Employee employee)
         {
             var EmployeeToUpdate=emp.Where(ctr=>ctr.EmpId==employee.EmpId).SingleOrDefault();  
            if(EmployeeToUpdate!=null)
            {
               EmployeeToUpdate.EmpName=employee.EmpName;
                EmployeeToUpdate.EmpAge=employee.EmpAge;
               
            }
         }

         public Employee Find(int id)
         {
           var EmployeeToFind=emp.Where(ctr=>ctr.EmpId==id).SingleOrDefault();  
           return EmployeeToFind;
         }
    }
}