using System;
using System.Collections.Generic;
using System.Linq;
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
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestantToAdd)
        {
            //BUGFIX IDEAS: Check for no duplicates, Check for dictionary, Has the contest closed, 


            if (contestants is null)
            {
                throw new ArgumentNullException(nameof(contestants));
            }
            if (contestantToAdd is null)
            {
                throw new ArgumentNullException(nameof(contestantToAdd));
            }

            //Add contestant to dictionary

            bool ContainsKey = contestants.ContainsKey(contestantToAdd.registration);
            if (ContainsKey)
            {
                return;

            }
            contestants.Add(contestantToAdd.registration, contestantToAdd);
        }
        public Contestant PickWinner()
        {
            //randomly pick winner and return from dictionary, collect registration # from Contestant, Selecting registration # from dictionary,   

            var newKey = contestants.Keys.ToList();
            Random random = new Random();
            int num = random.Next(0, newKey.Count - 1);
            var SelectedKey = newKey[num];
            var ContestantWinner = contestants[SelectedKey];
            return ContestantWinner;
        }


        public void PrintContestInfo(Contestant contestantToPrint)
        {
            //consol write line to print contestant info
            //TODO: Use UserInterface class
            Userinterface.Display("Contestant Info:");
            Userinterface.Display(contestantToPrint.first);
            Userinterface.Display(contestantToPrint.last);
            Userinterface.Display(contestantToPrint.email);

        }
    }
}
