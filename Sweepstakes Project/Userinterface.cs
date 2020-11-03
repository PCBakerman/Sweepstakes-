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
            Display(output);
            return Console.ReadLine();



        }
    
    }
}
