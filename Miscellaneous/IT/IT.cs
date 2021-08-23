namespace Miscellaneous.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int empID;
        static string Cafetaria;

        public Taazaa(int eid,double sal)
        {
            Salary=sal;
            empID=eid;
        }
        static Taazaa()
        {
            Cafetaria="100 sqft";
        }
        public int EmployeeID()    //Member Function
        {
            return empID;
        }
        public static string Coffeehouse()   //static Function
        {
            return Cafetaria;
        }
        public double EmployeeSalary()  //Member Function
        {
            return Salary;
        }

    }
}