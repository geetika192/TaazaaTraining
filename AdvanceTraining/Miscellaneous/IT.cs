using System;
namespace AdvanceTraining.Miscellaneous
{
    public class IT
    {
       static IT()  //Static Constructor
       {
          Console.WriteLine("Im static Constructor");
       } 
       public static string CompanyAddress()
       {
           return("Taazaa Noida");
       }
    }
}