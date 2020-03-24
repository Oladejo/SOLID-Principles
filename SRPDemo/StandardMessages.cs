﻿using System;

namespace SRPDemo
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Single Responsiblility Principle!");
        }

        public static void EndApplication()
        {
            Console.Write("Press Enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
    }
}
