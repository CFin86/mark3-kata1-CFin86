using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {

            var Ask = new Start();
            var hasAccount = Ask.AccountQuestion();

            var firstName = Ask.FirstNameQuestion();

            var lastname = Ask.LastNameQuestion(hasAccount, firstName);

            var pin = Ask.PinQuestion( firstName, lastname);


            var user = new User(hasAccount, firstName, lastname, pin);
            user.UserInfo();
        }
    }
}
