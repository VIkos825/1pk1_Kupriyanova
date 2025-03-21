namespace Task_19_03
{
    internal class Program
    {
        /*3. Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод 
         * (ввод каждой строки подтверждается нажатием на enter). количество введенных строк произвольно, 
         * ввод завершается при вводе пустой строки. 
         * После окончания ввода произведите объединение всех ранеее введенных строк
         * в одну с использованием разделителя «-»
         */

        static void Main(string[] args)
        {
            string[] lines = new string[1000];
            string input;
            int n = 0;
            int m = 1;
            while (true)
            {
                Console.WriteLine($"Введите строку {m}: ");
                input = Console.ReadLine();
                if (input == "") break;
                lines[n] = input;
                m++;
                n++;
            }
            string[] str = new string[n];
            Array.Copy(lines, 0, str, 0, n);
            string result = string.Join("-", str);
            Console.WriteLine("Рузультат: " + result);
        }
    }
}
