using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Выберите любую папку на своем компьютере, имеющую вложенные директории. 
 * Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Введите путь:");
            string path = Console.ReadLine();
            GetAll(path);
            PressToExit();
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
        static void GetAll(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (string f in files)
            {
                PrintLine(f);
            }
            foreach (string d in dirs)
            {
                GetAll(d);
            }
        }
    }
}
