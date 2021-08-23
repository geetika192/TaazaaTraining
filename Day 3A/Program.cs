using System;

namespace dayy3
{
    class hclinfosystem
    {
        
        static void Main(string[] args)
        {
            //using object
            object x="rahul";// x is a variable of object type
            string y=(string)x;// at this point conversion takes place at this time we explicitly conver to string  
            Console.WriteLine(y);

            //using dynamic
            dynamic x1="rahul";// x is a variable of dynamic type
            string y1=x1;// at this point conversion takes place at this time we explicitly conver to string  
            Console.WriteLine(y1);

            //using var
            var x2="rahul";// x is a variable of var type
            string y2=x2;// at this point conversion takes place at this time we explicitly conver to string  
            Console.WriteLine(y2);
            

        }
    }
}
