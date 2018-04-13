using System;
namespace OnboardingExperience
{
    public class User
    {
        public bool IsAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LogInPinNum { get; set; }



        public User(bool hasAccount, string FName, string LName, int PIN)
        {
            IsAccount = hasAccount;
            FirstName = FName;
            LastName = LName;
            LogInPinNum = PIN;
        }


        public void UserInfo()
        {
            Console.WriteLine($"Thank you {IsAccount}thfully {FirstName} {LastName} with PIN " +
                              $"(Personal Identification Number) number of {LogInPinNum}. " +
                              "\nWage slaves like you are what makes the world go'round"
                             );
        }
    }
}