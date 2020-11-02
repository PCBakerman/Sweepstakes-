using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    public class Simulation
    {

        public ISweepstakesManager Manager;
        public Simulation(SweepstakesManager sweepstakesManager)
        {
            Manager = sweepstakesManager;

        }

        public Simulation(OnlineSweepstakeManager onlineSweepstakeManager)
        {
            Manager = onlineSweepstakeManager;
            onlineSweepstakeManager.helpMeNate
        }
        public void doinSomthing()
        {
            Manager.add();
            Manager.helpMeNate;
        }
    }
}
