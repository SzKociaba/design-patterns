
using System;
namespace Zadanie
{

    public class Logger
    {
        private static Logger instance;
        private static readonly object lockObj = new object();
        private List<string> messageLog;

        private Logger()
        {
            messageLog = new List<string>();
        }

        public static Logger Instance()
        {
            if (instance == null)
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        {
                            instance = new Logger();
                        }
                    }
                }
            return instance;
        }
        public void LoggActivity(string log)
        {
            messageLog.Add(log);
        }

        public void readLog()
        {
            int logLength = messageLog.Count;
            for (int i = 0; i < logLength; i++)
            {
                System.Console.WriteLine($"Log ({i}): {messageLog[i]}");
            }
        }
    }
}

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


