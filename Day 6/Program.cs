using System;
using Day6.Collections;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var can=new Candidate();
            string temp=can.AddCandidatesName();
            Console.WriteLine(temp);
            can.AddCandidatesNames();

        }

    }
}
