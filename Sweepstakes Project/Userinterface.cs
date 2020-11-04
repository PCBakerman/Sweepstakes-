using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public static class Userinterface
    { 
    
    
        public static void Display(string output)
        {

            Console.WriteLine(output);

        }
        public static string GetUserPrompt(string output)
        {
            bool vaildinput = false;
            string input = "";
            do
            {
                Display(output);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Display("Incorrect input.");
                    vaildinput = false;
                }
                else
                {
                    vaildinput = true;
                }

            } while (vaildinput!);
            return input;
        }
        public static int GetUserPromptNumber(string output)
        {
            bool vaildinput = false;
            int input = 0;
            do
            {
                Display(output);
                
                if (int.TryParse(Console.ReadLine(), out input))
                {
                     vaildinput = true;
                }
                else
                {Display("Incorrect input, please enter a number.");
                    
                    vaildinput = false;
                }

            } while (vaildinput!);
            return input;
        }
        public static Contestant GetContestantInfo()
        {
            var first = GetUserPrompt("What is Contestant first name?");
            var last = GetUserPrompt("What is Contestant last name?");
            var email = GetUserPrompt("What is Contestant email address?");
            var registrationnumber = GetUserPromptNumber("What is Contestant registration number?");


            Contestant contestant = new Contestant(last, first, email, registrationnumber);
            return contestant;

        }
    
    }
}
