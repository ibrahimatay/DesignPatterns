using System;

namespace DesignPatterns.Adapter.LoggerSystem
{
    public class FileLogger : ILogger
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public int Priority { get; set; }
        public void Write()
        {
            Console.WriteLine(
                $"Message:{Message} \n " +
                $"Code:{Code} \n " +
                $"Priority:{Priority}");
        }
    }
}