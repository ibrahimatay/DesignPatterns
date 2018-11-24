namespace DesignPatterns.Command
{
    public class Controller
    {
        public void Invoke(ICommand command)
        {
            command.Execute();
        }
    }
}