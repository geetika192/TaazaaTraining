using System;
//using SpecialTopic.Param;
namespace SpecialTopic
{
    class Program
    {
        static void Main()
        {
             AddNumbers(10,20,29,39,48);
        }
        public static void AddNumbers(int FirstNumber, int SecondNumber, params object[] Param)
        {
            int result= FirstNumber+SecondNumber;
            if(Param!=null)
            {
                foreach(int i in Param)
                {
                    result+=i;
                }
            }
            System.Console.WriteLine("Sum="+ result);
        }
    }
}
