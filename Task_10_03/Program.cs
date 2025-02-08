namespace Task_10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxInArray(new int[] { 1,2,3}));
            int[] data = GetGeneratedArray(10);
            PrintArray(data, ' ');
        }
        /// <summary>
        /// ищет макс значение в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns>макс значение</returns>
        public static int GetMaxInArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        /// <summary>
        /// генерация массива
        /// </summary>
        /// <param name="length"></param>
        /// <returns>кол-во элементов</returns>
        public static int[] GetGeneratedArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0,100);
            }
            return array;
        }
        public static void PrintArray(int[] array, char separator)
        {
            foreach (char c in array)
                Console.Write(c + separator.ToString());
        }
    }
}
