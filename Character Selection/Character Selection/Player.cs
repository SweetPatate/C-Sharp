using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Selection
{
    public class Player
    {
        private string __name;
        private int __dexterity;
        private int __intelligence;
        private int __strength;
        private int __vitality;
        private int __NBpicture;

        public Player(string name,int dexterity, int intelligence, int strength, int vitality, int NBpicture)
        {
            __name = name;
            __dexterity = dexterity;
            __intelligence = intelligence;
            __strength = strength;
            __vitality = vitality;
            __NBpicture = NBpicture;
        }

        public string getName()
        {
            return __name;
        }

        public int getDext()
        {
            return __dexterity;
        }

        public int getInt()
        {
            return __intelligence;
        }

        public int getStrength()
        {
            return __strength;
        }

        public int getVita()
        {
            return __vitality;
        }

        public int getNBpicture()
        {
            return __NBpicture;
        }
    }
}
