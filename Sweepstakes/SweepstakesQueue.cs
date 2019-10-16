using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
     class SweepstakesQueue 
    {
        public Queue<Sweepstakes> queue;

        public SweepstakesQueue()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void AddToQueue(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes RemoveFromQueue(Sweepstakes sweepstakes)
        {
            //how does this work?

           return queue.Dequeue();
        }


    }
}
