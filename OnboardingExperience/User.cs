using System;
namespace OnboardingExperience
{
    public class User
    {
        public bool isAccount { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int logInPinNum { get; set; }

        public User(bool hasAccount, string fName, string lName, int PIN)
        {
            isAccount = hasAccount;
            firstName = fName;
            lastName = lName;
            logInPinNum = PIN;
        }

        public void UserInfo()
        {
            Console.WriteLine($"Thank you {isAccount}thfully {firstName} {lastName} with PIN " +
                              $"(Personal Identification Number) number of {logInPinNum}. " +
                              "\nWage slaves like you are what makes the world go'round"
                             );
        }
    }
}