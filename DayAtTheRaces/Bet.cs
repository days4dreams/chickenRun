using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount; //The amount of cash bet
        public int Chicken; //the number of the chicken the bet is on
        public Guy Bettor; // the guy who placed the bet

        public Bet(int Amount, int Chicken, Guy Bettor)
        {
            this.Amount = Amount;
            this.Chicken = Chicken;
            this.Bettor = Bettor;
        }


        public string GetDescription()
        {
            //Return a string that says who placed the bet, how much
            // cash was bet, and  which chick they bet on
            //If the amount is zero, no bet was places "X hasn't bet".
            string BetSummary;
            if (Amount != 0)
            {
                BetSummary = Bettor.Name + " has bet £" + Amount + " on Chick " + Chicken;
                return BetSummary;
            }
            else
            {
                BetSummary = Bettor.Name + " has not placed a bet.";
                return BetSummary;
            }
            
        }

        public int PayOut(int Winner)
        {
            //The parameter is the winner of the race. If the Chick won,
            // return the amount bet. Otherwise, return the negative of the amount bet.
            if (Chicken == Winner)
            {
                return Amount;
            }
            else
            {
                return --Amount;
            }

        }
    }
}
