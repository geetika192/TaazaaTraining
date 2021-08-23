using System;
namespace selfAnalyase.Models
{
    public class Company
    {
        readonly int empID;
        double Salary;
        static string Cafetaria;

        public Company(int eid,double sal)
        {
            Salary=sal;
            empID=eid;
        }
        static Company()
        {
            Cafetaria="200 sqft";
        }
        public int EmployeeID()
        {
           return empID;
        }
        public static string Coffeehouse()
        {
            return Cafetaria;
        }
        public double EmployeeSalary()
        {
            return Salary;
        }

    }
}