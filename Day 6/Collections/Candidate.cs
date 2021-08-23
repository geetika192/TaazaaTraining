using System.Collections;
using System.Collections.Generic;
using System;
namespace Day6.Collections
{
    public class Candidate
    {
        public string AddCandidatesName()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("Geetika Shukla");   //Boxing
            arrayList.Add("Geetu");
            string Name=(string)arrayList[1];   //unboxing
            //Console.WriteLine(Name);
            return Name;
        }
         public void AddCandidatesNames()
        {
           List<string> obj=new List<string>();
           obj.Add("Geetika");
           obj.Add("Geetu");
           if(obj.Contains("Geetu"))
           {
               Console.WriteLine("Found");
           }
           else
           {
               Console.WriteLine("Not Found");
           }
        }
    }
}