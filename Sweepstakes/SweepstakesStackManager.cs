using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager
    {
        Stack<Sweepstakes> st;

        public SweepstakesStackManager()
            {
            st = new Stack<Sweepstakes>();
            }

        public void PushToStack(Sweepstakes sweepstakes)
        {
            st.Push(sweepstakes);
        }
        public Sweepstakes RemoveFromStack(Sweepstakes sweepstakes)
        {
            //how does this work? and does it?
            return st.Pop();
        }

        //does sweepstakes manager need to be a public interface?






    }
}
