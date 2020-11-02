using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public static class Userinterface
    { 
    
    
        public static string GetUserPrompt(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine();
            return input;
        }
    
    }
}
