using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMinds
{
    class Program
    {
        static void Main(string[] args)
        {
            string code;
            int length = 4;
            bool win = false;
            bool game = true;
            int vie;

            joueur joueur1 = new joueur(length, win);
            vie = joueur1.Vie;

            Console.WriteLine("Welcome to Masterminds");
            Random aleatoire = new Random();
            int chiffre1 = aleatoire.Next(10); //Génère un entier compris entre 0 et 9
            int chiffre2 = aleatoire.Next(10);
            int chiffre3 = aleatoire.Next(10);
            int chiffre4 = aleatoire.Next(10);
            code = chiffre1.ToString() + chiffre2.ToString() + chiffre3.ToString() + chiffre4.ToString();

            bool checkCode = false;
            while (checkCode == false)
            {
                for (int i = 0; i < length; i++)
                {
                    checkCode = false;
                    for (int j = 0; j <= 9; j++)
                    {
                        if (code != "" && (code.ElementAt(i).ToString() == j.ToString()) && code.Length == length)
                        {
                            checkCode = true;
                            break;                            
                        }
                    }
                    if (!checkCode)
                        {
                        checkCode = false;
                        Console.WriteLine("Nop try again, " + length + " numbers :");
                        code = Console.ReadLine();
                    }
                }
            }
            //Console.Clear();
            Console.WriteLine(length + " numbers have been chosen. Guess them in the correct order.");

            while (game)
            {
                joueur1.deviner();
                string guess = joueur1.Guess;
                int correct = 0; // nombres bon emplacement
                int imparfait = 0; // nombres mauvais emplacement

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (guess.ElementAt(i).ToString() == code.ElementAt(j).ToString())
                        {
                            if (code.ElementAt(i).ToString() == guess.ElementAt(i).ToString())
                            {
                                correct += 1;
                            }
                            else
                            {
                                imparfait += 1;
                            }
                        }
                    }
                }
                int wrong = length - (correct + imparfait); // nombre qui ne sont pas dans le code

                if (correct != 0)
                {
                    Console.WriteLine("You have " + correct + " numbers correct");
                }
                if (imparfait != 0)
                {
                    Console.WriteLine("You have " + imparfait + " numbers in the wrong place");
                }
                if (wrong != 0)
                {
                    Console.WriteLine("You have " + wrong + " numbers are not in the code");
                }

                if ((correct == length) && vie > 0)
                {
                    win = true;
                    game = false;
                }
                if (correct != length)
                {
                    joueur1.life();
                }
                vie = joueur1.Vie;

                if (vie == 0)
                {
                    win = false;
                    game = false;
                    break;
                }
            }
            if (win)
            {
                Console.WriteLine("\nYOU WIN !!!\nCongratulation :-)");
                Console.WriteLine("The Secret Code was indeed " + code);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYOU LOOSE !!!\nMaybe next time");
                Console.WriteLine("The Secret Code was " + code);
                Console.ReadLine();
            }
        }
    }
}
