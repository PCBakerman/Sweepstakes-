using System;

namespace Sweepstakes_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant person1 = new Contestant();

            person1.firstName = Userinterface.GetUserPrompt("Please enter your first name");
        }
    }
}
