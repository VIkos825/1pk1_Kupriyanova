namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
        (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
        вывести сообщение что данная матрица не является Z-матрицей*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-9, 10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j || i < j && array[i, j] < 0)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    else if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i, j] + " ");
                        Console.ResetColor();
                    }
                    else Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
