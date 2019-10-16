using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
   static class UserInterface
    {

        
        

        

       public static void AddContestant(Contestant contestant)
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

        //call in program
        
                // make seperate methods for switch statement and to execute choose stack or queue?
                //help me tom cruise

            
        }

        

    }

