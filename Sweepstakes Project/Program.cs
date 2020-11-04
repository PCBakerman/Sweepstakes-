using System;

namespace Sweepstakes_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.CreateMarketingFirmWithManager();
            simulation.MarketingFirm.CreateSweepstake();
            Contestant contestant = Userinterface.GetContestantInfo();
            Sweepstakes sweepstakes = new Sweepstakes("Pat");
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestInfo(sweepstakes.PickWinner());
        }
    }
}
