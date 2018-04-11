using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to the First Third TrueCoders Bank!");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What is your PIN Number");
            string pin = Console.ReadLine();
            Console.WriteLine("Do you have an account");
            string hasAccount = Console.ReadLine();
          var user = new User(firstName, lastname, pin, hasAccount);
            Console.WriteLine($"Hey {firstName} {lastname} your pin is {pin} and you have an account {hasAccount}");
        }
    }
}
