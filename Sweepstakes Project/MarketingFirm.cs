using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public class MarketingFirm
    {
        ISweepstakesManager _Manager;
        //Injecting the ISweepstakeManage interface through the constructor so the manager class can be determined at runtime.
        //This allows the user to change how we manage the Sweepstakes without changing code.
        public MarketingFirm(ISweepstakesManager manager)
        {
            _Manager = manager;
        }

        public void CreateSweepstake()
        {
            //grab a name from user to insert into sweepstakes
            Sweepstakes sweepstakes = new Sweepstakes("Test");
            _Manager.InsertSweepstakes(sweepstakes);
        }
    }
}
