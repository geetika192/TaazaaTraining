using System.IO;
namespace Day8T1.FileHandling
{
    public class FileHandler
    {
        public void WriteToFile(string Name)
        {
            FileStream F = new FileStream("Training.txt",FileMode.Create);
            StreamWriter s = new StreamWriter(F);
            s.WriteLine(Name);
            s.Close();
            F.Close();
            System.Console.WriteLine("File write Successfully");
           
        }
        public void ReadFromFile()
        {
           FileStream F = new FileStream("Training.txt",FileMode.Open);
           StreamReader streamReader=new StreamReader(F);
           string Date=streamReader.ReadLine();
           System.Console.WriteLine(Date);
           streamReader.Close();
           F.Close();
           System.Console.WriteLine("File Read Successfully"); 
        }
    }
} 