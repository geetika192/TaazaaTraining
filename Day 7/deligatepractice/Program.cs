using System;
using deligatepractice.Noida;
delegate int BrokerDelegate();
namespace deligatepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new Broker();
            BrokerDelegate cobj=new BrokerDelegate(obj.Flat1);
             System.Console.WriteLine(cobj.Invoke());
        }
    }
}
