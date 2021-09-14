using System;
namespace Day8T.AdvDelegate
{
    public class Study
    {
        public string Name(string N)   //func
        {
           return N;
        }
         public void PhoneNumber()   //action
        {
           System.Console.WriteLine("34555");
        }
         public bool StudyStatus(string n)    //predicate
        {
           return true;
        }
    }
}