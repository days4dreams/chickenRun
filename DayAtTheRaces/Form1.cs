using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Chick[] chickens = new Chick[4];
        Guy[] guys = new Guy [3];
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            SetUpRaceTrack();
            //chickens = new Chick[4];
            //initialize four chick objects and array of chick objects
        }

        private void SetUpRaceTrack()
        {
            chickens[0] = new Chick()
            {
                MyPicture = animalOne,
                StartPosition = 0,
                RaceTrackLength = pictureBoxTrack.Width,
                Randomizer = Randomizer,
                Location = animalOne.Left
            };

            chickens[1] = new Chick()
            {
                MyPicture = animalTwo,
                StartPosition = 0,
                RaceTrackLength = pictureBoxTrack.Width,
                Randomizer = Randomizer,
                Location = animalOne.Left
            };

            chickens[2] = new Chick()
            {
                MyPicture = animalThree,
                StartPosition = 0,
                RaceTrackLength = pictureBoxTrack.Width,
                Randomizer = Randomizer,
                Location = animalOne.Left
            };

            chickens[3] = new Chick()
            {
                MyPicture = animalFour,
                StartPosition = pictureBoxTrack.Left,
                RaceTrackLength = pictureBoxTrack.Width,
                Randomizer = Randomizer,
                Location = animalOne.Left
            };

            guys[0] = new Guy("Joe", null, 50, joeRadioButton, joeStatusLabel);

            guys[1] = new Guy("Bob", null, 75, bobRadioButton, bobStatusLabel);

            guys[2] = new Guy("Al", null, 45, AlRadioButton, alStatusLabel);

            foreach(Guy guys in guys)
            {
                guys.UpdateLabels();
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBettor("joe");
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBettor("Bob");
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBettor("Al");
        }

        private void SetBettor(string Name)
        {
            this.Name = Name;
            /* CurrentBettor = guys[index];
            if (CurrentBettor.MyBet != null)//take the bet for the current bettor
            {
                CurrentBettor.MyBet.Amount = Convert.ToInt32(amountInput.Value);
                CurrentBettor.MyBet.Chicken = Convert.ToInt32(chickInput.Value);
            }
            else// reset the updown controls
            {
                amountInput.Value = 5;
                chickInput.Value = 1;
            } */
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (joeRadioButton.Checked)
            {
                GuyNumber = 0;
            }
            if (bobRadioButton.Checked)
            {
                GuyNumber = 1;
            }
            if (AlRadioButton.Checked)
            {
                GuyNumber = 2;
            }

            guys[GuyNumber].PlaceBet((int)amountInput.Value, (int)chickInput.Value);
            guys[GuyNumber].UpdateLabels();
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            bool NoWinner = true;
            int winner = 0;
            int num_winners = 0;

            while (NoWinner)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(3);
                for (int i = 0; i < chickens.Length; i++)
                {
                    if (chickens[i].Run())
                    {
                        winner = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner! - Chick #" + winner);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.Collect(winner);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        for (int a = 0; a < chickens.Length; a++)
                        {
                            chickens[a].TakeStartingPosition();
                        }
                        break;
                    }
                }
            }
        }
            



        private void timer1_Tick(object sender, EventArgs e)
        {
          //  for (int i = 0; i < chickens.Length; i++)
           // {
               // chickens[i].Run();
           // }
        }
    }   
}
