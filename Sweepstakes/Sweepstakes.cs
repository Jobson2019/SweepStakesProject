using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Contestant Winner;


        public Sweepstakes(string name)
        {
            
        }

        
        public void RegisterContestant(MarketingFirm marketingFirm)
        {
            Contestant customerToAdd = marketingFirm.CreateContestant();


            while(contestants.ContainsKey(customerToAdd.registrationNumber))
            {
                customerToAdd.registrationNumber = marketingFirm.GenerateRandomNumber();
            }

            
          contestants.Add(customerToAdd.registrationNumber, customerToAdd);
           
            
        }
        // sweepstakes (stringname)

        // void registercontestant(contestant contestant)
        
        //contestant pickwinner()
        // change to create chronological array, instead of picking random number
        public void PickWinner(MarketingFirm marketingfirm)
        {
            int winningNumber = marketingfirm.GenerateRandomNumber();

            //contestants.ContainsKey(customerToAdd.registrationNumber);
            while (!contestants.ContainsKey(winningNumber))
                 {
                winningNumber = marketingfirm.GenerateRandomNumber();
                 }
             Winner =  contestants[winningNumber];
         
        }

        //void PrintContestantInfo(Contestant contestant)

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
