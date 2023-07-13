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


            while (true)
            {
                Console.Write("\nВведите ID пользователя: ");
                try
                {
                    int userId = Int32.Parse(Console.ReadLine());
                    users[userId - 1].Greeting();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            

        }



    }
}