using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {

        public string Name; // the guys name
        public Bet MyBet; //an instance of Bet object that has his bet
        public int Cash; // amount of cash he has
        //last two fields are the guys GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        public void UpdateLabels()
        {
            //set mylabel to my bet's description and the label on my radio button to show cash
            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

        }

        public void ClearBet()
        {
            //reset bet to zero
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Chicken)
        {
            //Place a new bet and store it in my bet field
            //Return true if the guy has enough to bet
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Chicken, this);
                return true;
            }
            return false;
            string noCash = "You're out of cash, dude!";
            MessageBox.Show(noCash);                
        }


        public void Collect(int Winner)
        {
            //ask my Bet to pay out, clear my bet and update my labels
            MyBet.PayOut(Winner);
            UpdateLabels();
        }

    }
}
