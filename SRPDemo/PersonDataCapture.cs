using System;

namespace SRPDemo
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();

            Console.Write("What is your first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            person.LastName = Console.ReadLine();

            return person;
        }
    }
}
