using System;

namespace DesignPatterns.Adapter.LoggerSystem
{
    public class ServiceLogger : ILogger
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public int Priority { get; set; }
        
        public string ServiceName { get; set; }
        public string ServiceUrl { get; set; }

        public void Write()
        {
            Console.WriteLine($"Message:{Message} \n " +
                              $"Code:{Code} \n " +
                              $"Priority:{Priority} \n " +
                              $"ServiceName:{ServiceName} \n " +
                              $"ServiceUrl:{ServiceUrl}");
        }
    }
}