using System;

namespace Optionalp
{
    class Program
    {
        static public void scholar(string fname, string lname,int age = 20,string branch = "Computer science")
    {
        Console.WriteLine("First name: {0}", fname);
        Console.WriteLine("Last name: {0}", lname);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Branch: {0}", branch);
    }
    static public void Main()
    {
        scholar("Geetika", "Geetu");
        scholar("Divya", "Joshi", 30);
        scholar("mohan", "Joshi", 40,"computer Science");
    }
    }
}
