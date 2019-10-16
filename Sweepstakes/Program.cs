using System;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create UI first, ask to choose stack or queue
            
            
            FactoryManager factory = new FactoryManager();
            ISweepstakesManager manager = factory.CreateSweepstakesManager();
            MarketingFirm firm = new MarketingFirm(manager);
            firm.CreateSweepStakes();
            
            
            
        }
    }
}
