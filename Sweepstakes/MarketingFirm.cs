using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public string contestant;
        public string userInput;
        public int random;
        //create a sweepstakes
        public int GenerateRandomNumber()
        {
            return random.Next(1, 500);
        }

        public void CreateRegNumber(Contestant contestant)
        {
            contestant.registrationNumber = GenerateRandomNumber();
        }

        public void CreateContestant(UserInterface userinterface)
        {
            Contestant newContestant = new Contestant();

            {
                UserInterface.AddContestant(newContestant);
            }
        }
    }
}
