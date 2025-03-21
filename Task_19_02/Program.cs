using System.IO;

namespace Task_19_02
{
    internal class Program
    {
        /* 2. Напишите программу, которая запрашивает у пользователя произвольный текст, 
         * содержащий предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на части:
         * a)	По пробелам (отдельные слова построчно)
         * b)	По предложениям (отдельные предложения построчно)
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            char sep1 = ' ';
            char sep2 = '.';

            string[] parts1 = str.Split(sep1);

            Console.WriteLine("\nРезультат разделения на слова: ");
            for (int i = 0; i <= (parts1.Length - 1); i++)
                Console.WriteLine(parts1[i]);

            string[] parts2 = str.Split(sep2);

            Console.WriteLine("\nРезультат разделения на предложения: ");
            for (int i = 0; i <= ( parts2.Length - 1); i++)
                Console.WriteLine(parts2[i]);
        }
    }
}
