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
        public void RemoveFromStack(Sweepstakes sweepstakes)
        {
            st.Pop(sweepstakes);
        }








    }
}
