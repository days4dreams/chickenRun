using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Chick
    {
        public int StartPosition; //Where I (the chick) start
        public int RaceTrackLength; //How long the track is
        public PictureBox MyPicture = null; //My Picture object
        public int Location = 0; //Where I am on the track
        public Random Randomizer; // An instance of Random

        public bool Run()
        {
            //Move forward either 1,2,3, or 4 spaces at random
            //Update the posiiton of my picture on the form as:
            // MyPicture.Left = StartingPosition + Location;
            //Return true if i won race

                if (MyPicture.Right <= MyPicture.Parent.Width)
                {
                    int Increase = (Randomizer.Next(2, 5));
                    MyPicture.Left = MyPicture.Left + Increase;
                    Location = Location + Increase;
                    MyPicture.Left = StartPosition + Location;
                    return false;
                }
                else
                {
                return true;
                }
            //if statement returns true if chick has reached edge of parent and therefore won
        }

        public void TakeStartingPosition()
        {
            //Reset my location to 0 and my Picture to starting position
            MyPicture.Left = StartPosition;
            Location = 0;
        }
    }
}
