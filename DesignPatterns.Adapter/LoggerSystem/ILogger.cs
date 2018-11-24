namespace DesignPatterns.Adapter.LoggerSystem
{
    public interface ILogger
    {
        string Message { get; set; }
        string Code { get; set; }
        int Priority { get; set; }
        void Write();
    }
}