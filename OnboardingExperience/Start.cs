using System;
namespace OnboardingExperience
{
    public class Start
    {
        public Start()
        {
            Console.WriteLine("Hello and Welcome to the First Third TrueCoders Bank!");
        }

        public static string question(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static bool accountQuestion()
        {
            var boolCheck = ErrorHandling.convertStringToBool(question("Do you have an account?"));
            if (boolCheck == true)
            {
                Console.WriteLine("Good! Let's continue");
                return true;
            }
            else
            {
                Console.WriteLine("You need an account to continue.");
                return accountQuestion();
            }
        }

        public string firstNameQuestion()
        {
            string fname = question("What is your first name?");

            var errorCheck = ErrorHandling.isString(fname);
            if (errorCheck == true)
            {
                Console.WriteLine($"Well, Hello there {fname}!");
                return fname;
            }
            else
            {
                return firstNameQuestion();
            }
        }

        public string lastNameQuestion(bool hasAccount, string fname)
        {
            string lname = question("What is your last name?");
            var errorCheck = ErrorHandling.isString(lname);
            if (errorCheck == true)
            {
                Console.WriteLine($"I am so sorry your Mother named you {fname} {lname}!");
                Console.WriteLine($"Alright, {fname} {lname}. It's {hasAccount} that you have an account.");
                return lname;
            }
            else
            {
                return lastNameQuestion(hasAccount, fname);
            }
        }

        public int pinQuestion(string fname, string lname)
        {
            string pin = question("What is your PIN (Personal Identification Number) Number?!?!?!");
            int pinAsaNum = ErrorHandling.isValidNumber(pin);
            if (pinAsaNum > 0)
            {
                return pinAsaNum;
            }
            else
            {
                return pinQuestion(fname, lname);
            }
        }
    }
}