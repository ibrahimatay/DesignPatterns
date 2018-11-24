using System;

namespace DesignPatterns.Command.Commands
{
    public class AddPostCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Add to Post");
        }
    }
}