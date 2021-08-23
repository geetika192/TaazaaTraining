using System;
using Day8T1.FileHandling;
namespace Day8T1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler=new FileHandler();
            //fileHandler.WriteToFile("My Name is Geetika Shukla");
            fileHandler.ReadFromFile();

        }
    }
}
