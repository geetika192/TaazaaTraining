using System;
using practiceList.StudentList;
namespace practiceList
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLists studentLists=new StudentLists();
            var temp=studentLists.AddStudentRecord();
             foreach(var i in temp)
            {
                Console.WriteLine(i.Studentrollno+" "+i.StudentName+" "+i.StudentMail);
            } 
            var temp2=studentLists.updateRecord();
            foreach(var i in temp2)
            {
                Console.WriteLine(i.Studentrollno+" "+i.StudentName+" "+i.StudentMail);
            }

            studentLists.deleteRecord();
            studentLists.searchRecord();

        }
    }
}
