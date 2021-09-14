using System;

namespace Indexerp
{
    class School
    {
        private object[] StudentRollno=new object[4];
        public object this [int i]
        {
            get
            {
                return StudentRollno[i];
            }
            set
            {
                StudentRollno[i]=value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           School school=new School();
           school[0]=1;
           school[1]=12;
           school[2]=13;
           school[3]=14;
           System.Console.WriteLine(school[0]+" "+school[1]+" "+school[2]+" "+school[3]);

        }
    }
}
