using System;

namespace _3_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string clientName = Console.ReadLine();
            Console.WriteLine("Кто вы по гороскопу?");
            string clientZodiacSing = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string clientAge = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            string clientWork = Console.ReadLine();
            Console.WriteLine("Вас зовут " + clientName + ", вам " + clientAge + ", ваш знак зодиака " + clientZodiacSing + ", вы работаете " + clientWork);
        }
    }
}
