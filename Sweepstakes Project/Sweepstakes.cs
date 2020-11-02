using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sweepstakes_Project
{
    public class Sweepstakes
    {

        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        public Sweepstakes(string name)
        {
            
        }
        public void RegisterContestant(Contestant contestantToAdd)
        {
            //add contestant to dictionary
        }
        public Contestant PickWinner()
        {
            //randomly pick winner and return from dictonary 
        }
        public void PrintContestInfo(Contestant contestantToPrint)
        {

            //consol write line to print contest info

        }
    }
}
