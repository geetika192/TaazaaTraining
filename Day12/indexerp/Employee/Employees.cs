namespace indexerp.Employee
{
    public class Employees
    {
      private int Eid;
      public int Empid 
      {
          get
          {
              return Eid;
          }
          set
          {
              Eid = value; // value is a keyword
          }
      } 
    }
}