using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    class MarketingFirm
    {
        ISweepstakesManager _Manager;
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
