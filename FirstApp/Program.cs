using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Здравствуйте, ведите Ваше имя : ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст : ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения : ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Вас зовут {0} \nВаш возраст {1}\nДата вашего рождения: {2}", name, age, birthdate);

            Console.ReadKey();
        }
    }
}
