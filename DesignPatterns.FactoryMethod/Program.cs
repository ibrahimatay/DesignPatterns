namespace DesignPatterns.FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IScreen screen = CreatorFactory.ScreenFactory(ScreenType.Web);
                
            screen.Draw();  
        }
    }
}