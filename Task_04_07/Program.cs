namespace Task_04_07
{
    internal class Program
    {
        /*
        В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
        отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
        мальчиков и девочек. При выводе избавиться от отрицательных значений.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] height = new int[30];

            int countOfBoys = 0;
            double heightOfBoys = 0;
            int countOfGirls = 0;
            double heightOfGirls = 0;

            for (int i = 0; i < height.Length; i++)
            {
                height[i] = rnd.Next(155, 186) * (rnd.Next(2) * 2 - 1); 

                if (height[i] < 0)
                {
                    heightOfBoys += Math.Abs(height[i]);
                    countOfBoys++;
                }
                else
                {
                    heightOfGirls += height[i];
                    countOfGirls++;
                }
            }
            Console.WriteLine($"Девочек в классе: {countOfGirls}, мальчиков: {countOfBoys}.");
            Console.WriteLine("Средний рост девочек: {0:g6}, средний рост мальчиков: {1:g6}", heightOfGirls / countOfGirls, heightOfBoys / countOfBoys);
        }
    }
}
