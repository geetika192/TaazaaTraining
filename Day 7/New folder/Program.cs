using System;
using day7.Deligate;
delegate int customDeligate(); //delegate is a keyword points to a func return int
namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new Person();
            customDeligate cobj=new customDeligate(obj.PhoneNumber); //cobj has ref of function phoneNumber
            Console.WriteLine(cobj.Invoke());

            cobj-=obj.walk;  ///this is known as multi cast delegate
            //know cobj has ref of both func PhoneNumber and Walk becoz both hv same return type
            Console.WriteLine(cobj.Invoke());
        }
    }
}
