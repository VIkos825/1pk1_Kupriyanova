namespace Task_05_04
{
    internal class Program
    {/*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
    диагональной (все элементы вне главной диагонали равны нулю)
    Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
    сообщение что матрица не является диагональной.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                }
            }
        }
    }
}
