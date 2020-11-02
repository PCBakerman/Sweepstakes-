using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    class MarketingFirm
    {


        public void CreateContestant()
        {
            string firstName = Userinterface.GetUserPrompt("First name");
            string firstName = Userinterface.GetUserPrompt("First name");
            string firstName = Userinterface.GetUserPrompt("First name");
            string firstName = Userinterface.GetUserPrompt("First name");

            Contestant contestant = new Contestant(firstName);
        }
    }
}
