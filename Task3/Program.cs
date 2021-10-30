using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Вручную подготовьте текстовый файл с фрагментом текста.
 * Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sCount = 0, rowCount = 0, wordCount = 0;
            PrintLine("Введите путь к файлу:");
            string path = Console.ReadLine();
            using(StreamReader sr = new StreamReader(path))
            {
                string row = sr.ReadLine();
                while (row != null)
                {
                    rowCount++;
                    sCount += row.Length;
                    foreach (string s in new string[] { "—", "-"})
                    {
                        row = row.Replace(s, "");
                    }
                    row = row.Replace("  ", " ");
                    wordCount += row.Split().Length;
                    row = sr.ReadLine();
                }

                PrintLine($"\nКоличество строк в файле = {rowCount}");
                PrintLine($"Количество символов в файле = {sCount}");
                PrintLine($"Количество слов в файле = {wordCount}");
                PressToExit();
            }
        }
        static void PrintLine(string str)
        {
            Console.WriteLine(str);
        }

        static void PressToExit()
        {
            PrintLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
