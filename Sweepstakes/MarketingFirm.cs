using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public string contestant;
        public string userInput;
        static Random random = new Random();
        //create a sweepstakes
        public int GenerateRandomNumber()
        {
            return random.Next(1, 10000);
        }

        public void CreateRegNumber(Contestant contestant)
        {
            contestant.registrationNumber = GenerateRandomNumber();
        }
        //move to sweepstakes?
        public Contestant CreateContestant()
        {
            Contestant newContestant = new Contestant();

            {
                UserInterface.AddContestant(newContestant);
                return newContestant;
            }     
        }
        public void StartSweepstakes()
        {


        }
    }
}
