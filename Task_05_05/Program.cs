using System;
namespace Task_03_06
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение 
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего 
        по следующему правилу: 
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом 
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в массиве: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов в массиве: ");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-99, 100);
                    if (array[i, j] < 0)
                    {
                        array[i, j] = -array[i, j];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (array[i, j] == 0)
                    {
                        array[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i, j] + " ");
                        Console.ResetColor();
                    }
                    else Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }


        }
    }
}