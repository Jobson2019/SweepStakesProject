﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class UserInterface
    {
        
        static Random random = new Random();
        

        

        public void AddContestant(Contestant contestant)
        {
            
            Console.WriteLine("Enter First Name Here");
            string inputFirst = Console.ReadLine();
            contestant.firstName = inputFirst;
            Console.WriteLine("Enter Last Name Here");
            string inputLast = Console.ReadLine();
            contestant.lastName = inputLast;
            Console.WriteLine("Enter Email Address Here");
            string inputEmail = Console.ReadLine();
            contestant.emailAddress = inputEmail;
            
        }

 
    }
}