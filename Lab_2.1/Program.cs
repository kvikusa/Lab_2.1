using System;

namespace Lab_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тестируем базовый класс User
            User user1 = new User(true, true);
            Console.WriteLine("1 пользователь: " + user1);
            user1.Negate();
            Console.WriteLine("1 пользователь после отрицания: " + user1);

            // Тестируем конструктор копирования
            User user2 = new User(user1);
            Console.WriteLine("2 пользователь (копирует даннные 1-го пользователя): " + user2);

            // Тестируем дочерний класс PremiumUser
            PremiumUser premiumUser = new PremiumUser(true, true, 1);
            Console.WriteLine("Пользователь с подпиской: " + premiumUser);
            premiumUser.Podpiska();
            Console.WriteLine("Уровень подписки пользователя после повышения: " + premiumUser);
            Console.WriteLine("Имеет доступ к премиум-контенту: " + premiumUser.PremiumAccess());

            // Тестируем отключение аккаунта
            premiumUser.Active = false;
            Console.WriteLine("Отключени аккаунта: " + premiumUser);
            Console.WriteLine("Имеет доступ к премиум-контенту: " + premiumUser.PremiumAccess());
        }
    }
}
 