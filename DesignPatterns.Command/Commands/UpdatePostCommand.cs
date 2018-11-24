using System;

namespace DesignPatterns.Command.Commands
{
    public class UpdatePostCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Update Post");
        }
    }
}