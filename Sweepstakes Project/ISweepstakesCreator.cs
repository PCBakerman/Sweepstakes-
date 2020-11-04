using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public interface ISweepstakesCreator
    {

        public ISweepstakesManager Create(string managertype);

    }


}
