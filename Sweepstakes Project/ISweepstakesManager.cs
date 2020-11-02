using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public interface ISweepstakesManager
    {
        public void InsertSweepstakes(Sweepstakes sweepstakes);

        //What any Sweepstakes manager needs to do


        public Sweepstakes GetSweepstakes();


    }
}
