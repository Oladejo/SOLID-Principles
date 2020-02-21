using System;

namespace SRPDemo
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            Console.WriteLine($"Your person name is {person.FirstName.Substring(0, 1) }{ person.LastName }");
        }
    }
}
