using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Contestant Winner;
        public string name;

        public Sweepstakes(string name)
        {
            this.name = name;
        }


        public Contestant CreateContestant()
        {
            Contestant newContestant = new Contestant();

            {
                UserInterface.AddContestant(newContestant);
                return newContestant;
            }
        }


        public void RegisterContestant(MarketingFirm marketingFirm)
        {
            Contestant customerToAdd = CreateContestant();


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
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);

        }
    }
}
