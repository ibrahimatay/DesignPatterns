using System;

namespace DesignPatterns.Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            File file1 = new File("File 1");
            File file2 = new File("File 2");
            File file3 = new File("File 3");

            Folder folder1 = new Folder("Folder 1");
            folder1.Add(file1);
            folder1.Add(file2);
            folder1.Add(file3);

            Folder folder2 = new Folder("Folder 2");
            File file4 = new File("File 4");
            File file5 = new File("File 5");

            folder2.Add(file4);
            folder2.Add(file5);
            
            folder1.Add(folder2);
            
            folder1.DoubleClick();
 

            Console.ReadLine();
        }
    }
}