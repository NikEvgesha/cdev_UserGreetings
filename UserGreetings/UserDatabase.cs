using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

namespace UserGreetings
{
    internal class UserDatabase
    {
        Random random = new Random();

        public User[] Create(int num)
        {
            User[] users = new User[num];
            for (int i = 0; i < num; i++) 
            {
                users[i] = new User();
                users[i].Id = i+1;
                users[i].Name = Faker.Name.First();
                users[i].Login = Faker.Internet.UserName();
                if (random.Next(2) == 1)
                {
                    users[i].IsPremium = true;
                }
            }
            return users;
        }

        public void Display(User[] users)
        {
            Console.WriteLine(new string('-', 5 + 20 + 20 + 10));
            Console.WriteLine("|{0,5}|{1,20}|{2,20}|{3,10}|", "ID", "Login", "Name", "Premium");
            Console.WriteLine(new string('-', 5 + 20 + 20 + 10));

            foreach (User user in users)
            {
                Console.WriteLine("|{0,5}|{1,20}|{2,20}|{3,10}|", user.Id, user.Login, user.Name, user.IsPremium);
            }
        }

    }
}
