using System.Globalization;

namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5
        Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив*/
        static void Main(string[] args)
        {
            int[,] array = new int[10,5];
            Console.WriteLine("Массив:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 1 && i <= 10) array[i, j] = array[i, j] + 2 + i * 2;
                    if (j == 2 && i <= 10) array[i, j] = array[i, j] + 3 + i * 3;
                    if (j == 3 && i <= 10) array[i, j] = array[i, j] + 4 + i * 4;
                    if (j == 4 && i <= 10) array[i, j] = array[i, j] + 5 + i * 5;
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nПеревернутый массив:");
            int[,] arrava = new int[5,10];
            for (int i = 0;i < 5; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    arrava[i,j] = array[j,i];
                    Console.Write(arrava[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
