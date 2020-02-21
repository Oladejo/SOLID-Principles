using System;

namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            Person user = new Person();

            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();


            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                user.FirstName = Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                user.LastName = Console.ReadLine();
                return;
            }
        }
    }
}
