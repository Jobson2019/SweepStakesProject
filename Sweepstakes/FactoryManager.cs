using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class FactoryManager
    {
        public ISweepstakesManager CreateSweepstakesManager()
        {
            Console.WriteLine("Would You Like to Use a 'Stack' or 'Queue'?");
            string sweepstakesChoice = Console.ReadLine();
            ISweepstakesManager startSweepstakes;
            if (sweepstakesChoice == "Stack")
            {
                startSweepstakes = new SweepstakesStackManager();
                return startSweepstakes;
            }
            else if (sweepstakesChoice == "Queue")
            {
                startSweepstakes = new SweepstakesQueueManager();
                return startSweepstakes;
            }
            else
            {
                return null;
            }



        }
    }
}
       
