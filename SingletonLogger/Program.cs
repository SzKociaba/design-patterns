
using System;
namespace Zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance();
            Logger loggerDuplicateTest = Logger.Instance();

            if (logger == loggerDuplicateTest)
            {
                System.Console.WriteLine("========");
                System.Console.WriteLine("Logger has only one instance!");
                System.Console.WriteLine("========");
                System.Console.WriteLine();
            }

            Thread process1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    logger.LoggActivity($"message {i} - process 1");
                    Thread.Sleep(20);
                }
            });

            Thread process2 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    logger.LoggActivity($"message {i} - process 2");
                    Thread.Sleep(10);
                }
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            logger.readLog();
        }
    }
}

