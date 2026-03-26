using System;
using System.IO;

namespace Module1_2_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string logFile = "logPD24.txt";

            File.WriteAllText(logFile, "Початок");

            MessagePub pub = new MessagePub();
            FileLogger logger = new FileLogger(logFile);

            pub.OnMessageSent += logger.LogMessage;
            Console.WriteLine("4 повідомлення");

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Текст {i}: ");
                string input = Console.ReadLine();
                pub.Send(input);
            }
            Console.WriteLine("\nНаписано.");
        }
    }
}