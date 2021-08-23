using System;
using  Assign.Taazaaa;
using System.Collections;
namespace Assign
{
    class Program
    {
        static void Main()
        {
            var obj=new Collections();
            var arrayList=obj.galaxayAdd();
            int count=arrayList.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(arrayList[i]);
            }  
            var objlist=new  Collections();
            var List=objlist.galaxyDetails();
            int count1=List.Count;
            for(int i=0;i<count1;i++)
            {
                Console.WriteLine(List[i].Name+"  " +List[i].MegaLightYears);
            }  

        }
    }
}
