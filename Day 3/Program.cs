using System;

namespace day3
{
    //constructor chaining 
    class Hclinfosystem
    {
       
       
        public static void Main()
        {
          
            string adr="lajpat nagar";
            Hclinfosystem obj=new Hclinfosystem();
            obj.changeadd(ref adr);
            Console.Writeline(adr); //output will lajpat nagar or noida

        }
        public void changeadd(ref string ad)
        {
           ad="noida";

        }
    }
}
