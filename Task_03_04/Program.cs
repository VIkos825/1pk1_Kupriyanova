namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
        *пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
        *введенных пользователем.*/
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите текст:");
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "exit")
                    break;
                else
                    count++;
                Console.Clear();
            }
            Console.WriteLine("Вы ввели " + count + " строк(и)!");

        }
    }
}
