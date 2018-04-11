using System;
namespace OnboardingExperience
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LogInPinNum { get; set; }
        public string IsAccount { get; set; }

        //public User()
        //{
        //}

        public User(string FName, string LName, string PIN, string hasAccount){
                FirstName = FName;
                LastName = LName;
                LogInPinNum = PIN;
                IsAccount = hasAccount;
            }

        }
    }