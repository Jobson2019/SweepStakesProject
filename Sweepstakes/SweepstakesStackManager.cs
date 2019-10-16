using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> st;

        public SweepstakesStackManager()
            {
            st = new Stack<Sweepstakes>();
            }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            st.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            //how does this work? and does it?
            return st.Pop();
        }

        //does sweepstakes manager need to be a public interface?






    }
}
