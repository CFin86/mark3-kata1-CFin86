using System;
namespace OnboardingExperience
{
     class CheckFor
    {
       
       public static bool IsBoolean(string input)
        {  
            string response = input;
            response = response.ToLower();

            while (true)
            {
                if ("yes" == response || "y" == response)
                {
                    return true;
                }
                else if ("no" == response || "n" == response)
                {
                    Console.WriteLine("Big Gulps, huh? Welp. See ya later");
                    Environment.Exit(-1);
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input! i.e. Y, Yes, n, or No");
                    return false;
                }
            }
        }

        public static bool IsString(string Name)
        {
            string deathString = "!@#$%^&(())_{}:\"?><.//1234567890=";
            char[] deathArray = deathString.ToCharArray();
            int InvalidCharacters = Name.IndexOfAny(deathArray);
            if (InvalidCharacters == -1)
            {
                return true;

            }
            else
            {
                Console.WriteLine("I see you are a 1337 haxors. \n Will you please input a valid name?");
                return false;
            }
        }



        public static int IsValidNumber(string pinNumber)
        {
            bool result = Int32.TryParse(pinNumber, out int inputNumber);
            if (result)
            {
                Console.WriteLine($"Ok. Your pin is {inputNumber}");
                return inputNumber;
            }
            else
            {
                Console.WriteLine($"What you inputted ({pinNumber})" +
                                  " is not an integral number. Try again.");
                return inputNumber;
            }
        }
    }
}