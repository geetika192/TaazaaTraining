/* namespace SpecialTopic.Param
{
    public  class Param
    {
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
} */