using System;

namespace Minuteur
{
    internal class sablier
    {
        private int secondes;
        private int minutes;
        private int heures;

        private int secondesTotale;
        public sablier(int secondes, int minutes, int heures)
        {
            this.heures = heures;
            this.minutes = minutes;
            this.secondes = secondes;

            secondesTotale = this.secondes + this.minutes * 60 + this.heures * 3600;
        }

        public void convertionInverse()
        {
            heures = secondesTotale / 3600;
            minutes = (secondesTotale % 3600) / 60;
            secondes = (secondesTotale % 3600) % 60;
        }

        public void ClockSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        public int Secondes   // property
        {
            get { return secondes; }   // get method
            set { secondes = value; }  // set method
        }

        public int Minutes   // property
        {
            get { return minutes; }   // get method
            set { minutes = value; }  // set method
        }
        public int Heures   // property
        {
            get { return heures; }   // get method
            set { heures = value; }  // set method
        }
        public int SecondesTotale   // property
        {
            get { return secondesTotale; }   // get method
            set { secondesTotale = value; }  // set method
        }
    }
}