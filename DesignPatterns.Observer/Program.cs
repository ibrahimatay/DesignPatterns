namespace DesignPatterns.Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Page page = new Page();
            page.Subscribe(new Subscriber("İbrahim"));
            page.Subscribe(new Subscriber("Tom"));
            page.Subscribe(new Subscriber("Cartion"));

            page.AddToPage("test1");
            page.UpdateToPage("test2");
            page.DeleteToPage();
        }
    }
}