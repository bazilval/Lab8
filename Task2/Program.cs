using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
 * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sum = 0;
            string numString;
            string[] nums;
            string path = "D:/text.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(r.Next(0, 100));
                }
            }

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Int32.Parse(sr.ReadLine());
                }

            }

            PrintLine($"Сумма случайных чисел в файле {path} - {sum}.");
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
    }
}
