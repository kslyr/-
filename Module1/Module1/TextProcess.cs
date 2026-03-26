using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Module1
{
    public class TextProcess
    {
        public delegate string TextOper(string text);

        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
        public static string CountSymbols(string text)
        {
            return $"К-сть символів: {text.Length}";
        }
        public static string CountWords(string text)
        {
            char[] separators = { ' ', '\t', '.', ',', '!', '?', '-', ';' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return $"Кількість слів: {words.Length}";
        }
        public static void ProcessFile(string inputFile, string outputFile, TextOper oper, string operName)
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using(StreamWriter writer = new StreamWriter(outputFile, true))
            {
                writer.WriteLine($"Робота: {operName}");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string result = oper(line);

                    writer.WriteLine(result);

                }

            }
        }

    }
}
