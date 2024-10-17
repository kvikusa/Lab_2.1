using System;

namespace Lab_2_1
{
    public class User
    {
        //логические поля
        bool admin; //пользователь или адинистратор
        bool active; //активен или нет

        //аксессоры
        public bool Admin
        {
            get => admin;
            set => admin = value;
        }
        public bool Active
        {
            get => active;
            set => active = value;
        }

        //конструктор
        public User(bool admin, bool active)
        {
            this.admin = admin;
            this.active = active;
        }
        //конструктор копирования
        public User (User copy)
        {
            Admin = copy.Admin;
            Active = copy.Active;
        }
       
        //метод, вычисляющий отрицания полей
        public void Negate()
        {
            Admin = !Admin;
            Active = !Active;
        }

        //перегрузка ToString()
        public override string ToString()
        {
            return $"Пользователь: Админ - {Admin}, Активен - {Active}";
        }
    }

    public class PremiumUser : User
    {
        int subscriber; //уровень подписки пользователя

        //аксессор
        public int Subscrider { get => subscriber; set => subscriber = value; } 

        //конструктор
        public PremiumUser(bool admin, bool active, int sub) : base(admin, active) 
        {
            this.subscriber = sub;
        }

        // Метод для повышения уровня подписки
        public void Podpiska()
        {
            subscriber++;
        }

        // Метод для проверки доступа к премиум контенту
        public bool PremiumAccess()
        {
            return Active && subscriber > 0;
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            return base.ToString() + $", уровень подписки пользователя: {subscriber}";
        }
    }
}
