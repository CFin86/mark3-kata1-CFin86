using System;
namespace OnboardingExperience
{
    public class Start
    {
        public Start()
        {
            Console.WriteLine("Hello and Welcome to the First Third TrueCoders Bank!");
        }


        public static string Question(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        public bool AccountQuestion()
        {
            var boolCheck = CheckFor.IsBoolean(Question("Do you have an account?"));
            if ( boolCheck == true)
            {
                Console.WriteLine("Good! Let's continue");
                return true;
            }
            else
            {
                AccountQuestion();
                return false;
            }
        }


        public string FirstNameQuestion()
        {
            string fname = Question("What is your first name?");

            var errorCheck = CheckFor.IsString(fname);
            if (errorCheck == true)
            {
                Console.WriteLine($"Well, Hello there {fname}!");
                return fname;
            }
            else
            {
                return FirstNameQuestion();
            }
        }


        public string LastNameQuestion(bool hasAccount, string fname)
        {
            
            string lname = Question("What is your last name?");
            var errorCheck = CheckFor.IsString(lname);
            if (errorCheck == true)
            {
                Console.WriteLine($"I am so sorry your Mother named you {fname} {lname}!");
                Console.WriteLine($"Alright, {fname} {lname}. It's {hasAccount} that you have an account.");
                return lname;
            }
            else
            {
                return LastNameQuestion(hasAccount, fname);
            }
        }



        public int PinQuestion( string fname, string lname)
        {
            string pin = Question("What is your PIN (Personal Identification Number) Number?!?!?!");
            int pinAsaNum = CheckFor.IsValidNumber(pin);
            if (pinAsaNum >= 0)
            {
                return pinAsaNum;
            } else {
                return PinQuestion(fname, lname);
            }
        }

    }
}