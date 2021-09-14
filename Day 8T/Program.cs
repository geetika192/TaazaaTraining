using System;
using Day8T.AdvDelegate;
//delegate string  NameDelegate(string N);
//delegate void  PhoneDelegate();
//delegate bool  StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
            Study study=new Study();
            /* NameDelegate nameDelegate=new NameDelegate(study.Name);
            var temp=nameDelegate.Invoke("Geetika");
            System.Console.WriteLine(temp);
            PhoneDelegate phoneDelegate=new PhoneDelegate(study.PhoneNumber);
            phoneDelegate.Invoke();
            StudyDelegate studyDelegate=new StudyDelegate(study.StudyStatus);
            var temp1=studyDelegate.Invoke();
            System.Console.WriteLine(temp1);
 */
            Func<string,string> func=study.Name;   //func = string , int 
            string temp=func("Geetika");
            System.Console.WriteLine(temp);

            Action action = study.PhoneNumber;   //void
            action();

            Predicate<string> predicate=study.StudyStatus;   //boolean
            System.Console.WriteLine(predicate("geetu"));   

        }
    }
}
