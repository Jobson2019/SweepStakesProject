using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    interface ISweepstakesManager
    {
       public void InsertSweepstakes(Sweepstakes sweepstakes);

        public Sweepstakes GetSweepstakes();
        


    }
}
