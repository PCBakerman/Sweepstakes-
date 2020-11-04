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
        {
            //Declaring variable for manager
            ISweepstakesManager sweepstakesManager;

            //Intantiate sweepstakes factory.
            ISweepstakesCreator sweepstakesCreator = new SweepstakesFactory();

            bool correctinput = false;    
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
            //Use userinput to determin what we pass to our factory
            if (input.ToLower() == "s")
            {
                sweepstakesManager = sweepstakesCreator.Create("sssmanager");
            }
            else
            {
                sweepstakesManager = sweepstakesCreator.Create("ssqmanager");
            }
            //Inject sweepstakes manager into marketing firm.
            MarketingFirm = new MarketingFirm(sweepstakesManager);
        }
    } 
}
