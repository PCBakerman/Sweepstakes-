using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sweepstakes_Project
{
    public class Simulation
    {

        //public ISweepstakesManager Manager;
        //public Simulation(SweepstakesManager sweepstakesManager)
        //{
        //    Manager = sweepstakesManager;

        //}

        public Simulation()
        {

            
        }

        public void 
        {
            //utilize factory pattern to instantiate either a stackmanager or queuemanager
            //pass the created manager into a new marketing firm when we instantiate it
            public void CreateMarketingFirmWithManager(string sweepstakes)
            {
                switch (string Manager)
                {
                    case "SSSManager":
                        return new Simulation();
                    case "SSQManager":
                        return new Simulation();

            }
            public Item GetItemToPurchase(string item)
            {
                switch (item.ToLower())
                {
                    case "lemon":
                        return new Lemon();
                    case "sugar":
                        return new Sugar();
                }
        }
    }
}
