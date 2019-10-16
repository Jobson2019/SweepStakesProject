using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public string contestant;
        public string userInput;
        static Random random = new Random();
        public ISweepstakesManager manager;
        //create a sweepstakes
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public int GenerateRandomNumber()
        {
            return random.Next(1, 10000);
        }

        public void CreateRegNumber(Contestant contestant)
        {
            contestant.registrationNumber = GenerateRandomNumber();
        }
        //move to sweepstakes?
        


        public void CreateSweepStakes()
        {
            Console.WriteLine("Enter a name for your Sweepstakes");
            string name = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(name);
            manager.InsertSweepstakes(sweepstakes);
        }
        
    }
}
