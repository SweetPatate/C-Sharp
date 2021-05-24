using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMinds
{
    public class joueur
    {
        private int _length;
        private bool _win;
        private int vie;
        private string guess;

        public string Guess { get => guess; set => guess = value; }
        public int Vie { get => vie; set => vie = value; }

        public joueur(int length, bool win)
        {
            vie = 6;
            _length = length;
            _win = win;
        }

        public void deviner()
        {
            Console.WriteLine("Insert "+ _length +" numbers :");
            guess = Console.ReadLine();

            bool checkCode = false;
            while (checkCode == false)
            {
                for (int i = 0; i < _length; i++)
                {
                    checkCode = false;
                    for (int j = 0; j <= 9; j++)
                    {
                        if (guess != "" && (guess.ElementAt(i).ToString() == j.ToString()) && guess.Length == _length)
                        {
                            checkCode = true;
                            break;
                        }
                    }
                    if (!checkCode)
                    {
                        checkCode = false;
                        Console.WriteLine("Nop try again, " + _length + " numbers :");
                        guess = Console.ReadLine();
                    }
                }
            }
        }
        
        public void life()
        {
            if (_win == false)
            {
                vie -= 1;
                if (vie > 0)
                {
                    Console.WriteLine("you still have " + vie + " life");
                }
                else
                {
                    Console.WriteLine("you have no life left");
                    vie = 0;
                }
            }
        }
    }
}

