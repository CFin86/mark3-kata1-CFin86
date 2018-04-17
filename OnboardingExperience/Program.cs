using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var ask = new Start();
            var hasAccount = Start.accountQuestion();

            var firstName = ask.firstNameQuestion();

            var lastName = ask.lastNameQuestion(hasAccount, firstName);

            var pin = ask.pinQuestion(firstName, lastName);

            var user = new User(hasAccount, firstName, lastName, pin);
            user.UserInfo();
        }
    }
}
