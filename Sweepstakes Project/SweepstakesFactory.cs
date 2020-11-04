using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public class SweepstakesFactory : ISweepstakesCreator
    {
        public ISweepstakesManager Create(string managertype)
        {
                
            switch (managertype.ToLower())
            {
                case "sssmanager":
                    return new SSSManager();
                case "ssqmanager":
                default:
                    return new SSQManager();
            }

        }
    }
}
