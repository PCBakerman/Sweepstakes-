using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Sweepstakes_Project
{
    public class Contestant
          
        //Member Variables
    {
        public  string first;
        public string last;
        public  string email;
        public  int registration;

        public Contestant(string lastName, string firstName, string emailAddress, int registrationNumber)
        {
            //Constructor
     
          last = lastName;
          first = firstName;
          email = emailAddress;
          registration = registrationNumber;

        }

    }
}
