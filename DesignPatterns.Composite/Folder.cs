using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Folder : IPlaceHolder
    {
        public Folder(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        private List<IPlaceHolder> _files = new List<IPlaceHolder>();

        public void Add(IPlaceHolder file)
        {
            _files.Add(file);
        }

        public bool Remove(IPlaceHolder file)
        {
            return _files.Remove(file);
        }

        public void DoubleClick()
        {
            Console.WriteLine($"{Name} folder is Opened");

            foreach (IPlaceHolder placeHolder in _files)
            {
                placeHolder.DoubleClick();
            }
        }
    }
}