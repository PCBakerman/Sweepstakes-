using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes_Project
{
    class SSSManager : ISweepstakesManager  //Implements last in-first out function
    {
        private Stack<Sweepstakes> stack;
        public SSSManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;
            if (stack.TryPop(out sweepstakes))
            {
                return sweepstakes;
            }
            return null;
        }
      
        public void InsertSweepstakes(Sweepstakes sweepstakes)

        {
            stack.Push(sweepstakes);
        }
         
    }

}
