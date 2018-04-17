using System;
namespace OnboardingExperience
{
    class ErrorHandling
    {

        public static bool convertStringToBool(string input)
        {
            var response = input.ToLower();

            if ("yes" == response || "y" == response)
            {
                return true;
            }
            else if ("no" == response || "n" == response)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid input! i.e. Y, Yes, n, or No");
                return convertStringToBool(Start.question("Do you have an account?"));
            }
        }

        public static bool isString(string Name)
        {
            var deathString = "!@#$%^&(())_{}:\"?><.//1234567890= ";
            var deathArray = deathString.ToCharArray();
            var InvalidCharacters = Name.IndexOfAny(deathArray);
            if (InvalidCharacters == -1)
            {
                return true;
            }
            else
            {
                Console.WriteLine("I see you are a 1337 haxors. \nWill you please input a valid name?");
                return false;
            }
        }

        public static int isValidNumber(string pinNumber)
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