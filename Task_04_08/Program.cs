namespace Task_04_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
        которых равны.*/
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < array.Length; i++) array[i] = random.Next(0,100);
            for (int i = 1; i < array.Length; i++) if (array[i-1] == array[i]) count++;
            Console.Write(string.Join(", ", array));
            Console.WriteLine("\nКол-во пар чисел: " + count);
        }
    }
}
