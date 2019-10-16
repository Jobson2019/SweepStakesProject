using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
       public void InsertSweepstakes(Sweepstakes sweepstakes);

        public Sweepstakes GetSweepstakes();
        


    }
}
