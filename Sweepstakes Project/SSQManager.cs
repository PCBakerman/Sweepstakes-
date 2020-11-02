using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    class SSQManager : ISweepstakesManager  //Implements first in-first out function
    {
        private Queue<Sweepstakes> queue;
        private Dictionary<string, Sweepstakes> testDictonary;
        public SSQManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()     
            
        {
            Sweepstakes sweepstakes;
            if (queue.TryDequeue(out sweepstakes))
            {
                return sweepstakes;
            }
            return null;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        } 
    }
}
