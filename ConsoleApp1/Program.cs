namespace ConsoleApp1
{
    internal class Program
    {
        /*1. Напишите программу, в которой пользователь вводит произвольный текст в консоли, 
         * после чего программа запрашивает подстроку для поиска. 
         * Если подстрока найдена - то программа запрашивает текст для того чтобы 
         * заменить на него эту подстроку (столько раз, сколько раз подстрока встречена в тексте)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку для поиска: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите подстроку для замены: ");
            string b = Console.ReadLine();
            str = str.Replace(a, b);
            Console.WriteLine("Результат: " + str);
        }
    }
}
