using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
     class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            

           return queue.Dequeue();
        }


    }
}
