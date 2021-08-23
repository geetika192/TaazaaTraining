using System.Collections;
using System.Collections.Generic;
using Collection.Models;
namespace Collection.Taaza
{
    public class Candidatelist
    {
       public ArrayList Candidatedetails()
       {
        
           ArrayList arrayList=new ArrayList();
           arrayList.Add("Salman");
           arrayList.Add("geetika");
           return arrayList;

          
       } 
    
          public  List<candidate> Candidatedetail()
       {
           List<candidate> obj=new List<candidate>();
           obj.Add(new candidate{
               Cid=101,
               Cname="Nikhil"
           });
            obj.Add(new candidate{
               Cid=102,
               Cname="Nikks"
           });
           return obj;
           


        
           
          
       } 
    }
}
