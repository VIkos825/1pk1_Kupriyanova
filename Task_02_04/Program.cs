namespace Task_02_04
{
    internal class Program
    {
        /*Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
        расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
        этом*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());
            if (day <= 21 & month <= 1 & year <= 2007)
                Console.WriteLine("Вы являетесь совершеннолетним!");
            else Console.WriteLine("Вы не являетесь совершеннолетним!");
        }
    }
}
