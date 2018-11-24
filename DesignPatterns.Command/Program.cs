using DesignPatterns.Command.Commands;

namespace DesignPatterns.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommand addCommand = new AddPostCommand();
            ICommand updateCommand = new UpdatePostCommand();
            
            Controller controller = new Controller();

            controller.Invoke(addCommand);
            controller.Invoke(updateCommand);
        }
    }
}