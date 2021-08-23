using System.Collections;
using System.Collections.Generic;
using Assign.Models;
namespace Assign.Taazaaa
{
    public class Collections
    {
    
       public ArrayList galaxayAdd()
       {
        
           ArrayList arrayList=new ArrayList();
           arrayList.Add("Pinwheel");
           arrayList.Add("Andromeda");
           return arrayList;

          
       } 
    
          public  List<Galaxy> galaxyDetails()
       {
           List<Galaxy> theGalaxies=new List<Galaxy>();
           theGalaxies.Add(new Galaxy{
               Name="Tadpole",
               MegaLightYears=400
           });
            theGalaxies.Add(new Galaxy{
               Name="Milky way",
               MegaLightYears=0
           });
           return theGalaxies;
    }
    }
}