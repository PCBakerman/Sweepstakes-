using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sweepstakes_Project
{
    public class Simulation
    { 
        //Properties
        public MarketingFirm MarketingFirm
        {
            get; set;
        }


    
        public Simulation() //Contructor
        {

            
        }
        //Methods
        public void CreateMarketingFirmWithManager()
        { bool correctinput = false;
            //Get userinput for managertype.
            string input;
            do
            {
                input = Userinterface.GetUserPrompt("PLease select Queue or Stack Manager. Type Q for Queue and type S for Stack.");
                if (input.ToLower() == "s" || input.ToLower() == "q")
                {
                    correctinput = true;

                }else
                {
                    Userinterface.Display("Incorrect inuput, please select S or Q.");

                }

            } while (!correctinput);
            if (input.ToLower() == "s")
        }
    } 
}
