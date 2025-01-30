namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
        числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
        минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            int a = 100;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    if (array[i, j] < a) a = array[i, j];
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМинимальное число: " + a);
            Console.WriteLine("\nВсе элементы массива, умноженные на " + a);
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    array[i, j] *= a;
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
