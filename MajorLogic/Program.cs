using System;
//Program for Indexer
namespace MajorLogic
{
    public class Employee
    {
       private object[] data=new object[2];  //variable name is data and done indexing with 2 subscript.Ex-data[0]=101,data[1]="Getika"
       public object this[int i]  //this refers to object of Employee i.e, employee
       {
           get
           {
              return data[i];
           }
           set
           {
            data[i]=value;
           }
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee();  //here employee refer to this
            //using Indexer
            employee[0]=101;  //set //data[0]=employee[0]; , data[1]=employee[1];
            employee[1]=102;  //set

            System.Console.WriteLine(employee[0]); //get
            System.Console.WriteLine(employee[1]); //get  


        }
    }
}
