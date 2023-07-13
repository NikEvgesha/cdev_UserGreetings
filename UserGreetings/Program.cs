using System;

namespace UserGreetings
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDatabase userDB = new UserDatabase();
            Console.WriteLine("Сколько пользователей сгенерировать?");
            int num = Int32.Parse(Console.ReadLine());
            User[] users = userDB.Create(num);
            
            Console.WriteLine("Сгенерированные пользователи:");
            userDB.Display(users);

            Console.Write("\nВведите логин пользователя: "); 
            string login = Console.ReadLine();

            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    user.Greeting();
                }
            }

        }



    }
}