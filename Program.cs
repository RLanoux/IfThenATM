using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfThenATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            String sUserResp = String.Empty;
            Double dBalance = 0.0;
            Double dRequest = 0.0;
            Random rnd = new Random();

            //Generate a random number between 0.0 and 100.0 and store it
            dBalance = (Double)rnd.Next(0, 100);

            //Ask how much user wants to withdraw
            Console.Write("\nYour balance is $" + dBalance.ToString() + ". \nPlease enter the desired amount for this withdrawal (0.00 format): ");

            //Read user's response and store it
            sUserResp = Console.ReadLine();

            //Convert user's response to an actual number and store it
            dRequest = Convert.ToDouble(sUserResp);

            Boolean bTestCondition = dRequest > 100.00; /* Ask Hal about logic gates. */
            //Make sure they are not over the limit to withdrawals
            if (bTestCondition)
            {
                Pause("\nYour request exceeds the $100.00 limit.");
                return; /* Ends the method in the main program. */
            }

            //Compare user's request to user's balance (test condition)
            if (dBalance >= dRequest)
            {

                //      If user has enough money, grant his request
                Pause("\nPlease take your cash and press enter when you have it.");
                dBalance -= dRequest;
            }
            //Or else
            else
            {

                //      politely decline the request
                Pause("\nI'm sorry, but there are insufficient funds to complete this transaction.");
            }
            //Pause
            Pause("Press enter to close this window.");
        }

        static void Pause(String sMsg)
        {
            Console.WriteLine(sMsg);
            Console.ReadLine();
        }
    }
}
