using System;
using System.IO;

namespace Module1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string inputFile = "textPD24.txt";
            string outputFile = "resultPD24.txt";

            string initialtext = "Ціни на DDR4 злетіли майже в 9 разів за рік.\n" + "Мирон Маркевич обрав лідера збірної України перед матчем зі Швецією.\n" + "Топ-10 продуктів з найпотужнішими антиоксидантами.\n";

            File.WriteAllText(inputFile, initialtext);

            File.WriteAllText(outputFile, "Результат:");
            Console.WriteLine("Обробка...");

            TextProcess.ProcessFile(inputFile, outputFile, TextProcess.ToUpperCase, "UPERCASE");
            TextProcess.ProcessFile(inputFile, outputFile, TextProcess.CountSymbols, "К-сть символів");
            TextProcess.ProcessFile(inputFile, outputFile, TextProcess.CountWords, "К-сть слів");

            Console.WriteLine("Обробка завершена.\n");
        }
    }
}
