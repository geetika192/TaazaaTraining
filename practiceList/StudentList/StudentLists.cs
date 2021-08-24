using System.Collections.Generic;
using practiceList.Contacts;
using System;
namespace practiceList.StudentList
{
    public class StudentLists
    {
        List<Students> list;
        public StudentLists()
        {
            list=new List<Students>();
        }
        public List<Students> AddStudentRecord()
        {
            list.Add(new Students{
                Studentrollno=12,
                StudentName="Geetika",
                StudentMail="Geetika@gmail.com"
            });
            list.Add(new Students{
                Studentrollno=14,
                StudentName="Deepti",
                StudentMail="Deepti@gmail.com"
            });
             list.Add(new Students{
                Studentrollno=16,
                StudentName="Divya",
                StudentMail="Divya@gmail.com"
            });
            return list;
        }
             public List<Students> updateRecord()
        {
            int target = 1;
            list[target].StudentName="Geetu";
            list[target].StudentMail="Geetu@gmail.com";
            return list;
        }
        public void deleteRecord()
        {
            int target =0;
            list.RemoveAt(target);
            Console.WriteLine("Record Deleted!");
        }
        public void searchRecord()
        {
                 int target = 1;
                list.FindIndex(student =>student.Studentrollno ==target);
                Console.WriteLine("Found");
                Console.WriteLine("Name => "+list[target].StudentName+"\nEmail => "+list[target].StudentMail);
        }

        }
    }