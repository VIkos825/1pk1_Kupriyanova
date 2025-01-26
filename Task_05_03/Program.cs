namespace Task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
        да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
        элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.*/
        static void Main(string[] args)
        {
            char[,] chars1 = new char[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    chars1[i, j] = (char)rnd.Next(97, 122);
                    Console.Write(chars1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            char[,] chars2 = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    chars2[i,j] = (char)rnd.Next(97, 122);
                    Console.Write(chars2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    //
                }
            }
            
        }
    }
}
