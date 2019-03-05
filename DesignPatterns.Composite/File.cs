using System;

namespace DesignPatterns.Composite
{
    public class File : IPlaceHolder
    {
        public File(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void DoubleClick()
        {
            Console.WriteLine($"{Name} file is opened in a program");
        }
    }
}