using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
https://www.codingame.com/ide/puzzle/power-of-thor-episode-1
Thor évolue sur une carte de 40 cases de large et 18 cases de hauteur. Notez que les coordonnées (X et Y) commencent en partant du haut ! Ainsi la case la plus en haut à gauche a pour coordonnées "X=0,Y=0" et celle située le plus en bas à droite a pour coordonnées "X=39,Y=17".

Au début du programme vous recevez :
la variable lightX : la position X de l'éclair que Thor doit rejoindre.
la variable lightY : la position Y de l'éclair que Thor doit rejoindre.
la variable initialTX : la position X initiale de Thor.
la variable initialTY : la position Y initiale de Thor.
À la fin du tour de jeu, vous devez afficher la direction que Thor doit prendre parmi :
	
N (Nord)
NE (Nord-Est)
E (Est)
SE (Sud-Est)
S (Sud)
SW (Sud-Ouest)
W (Ouest)
NW (Nord-Ouest)
Chaque déplacement fait bouger Thor de 1 case dans la direction choisie.
 
 
Conditions de victoire
Vous gagnez lorsque Thor arrive sur l'éclair de puissance
 
Conditions de défaite
Thor sort de la carte
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        int thorX = initialTx;
        int thorY = initialTy;
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move.

            if(thorX < lightX & thorY < lightY){
                Console.WriteLine("SE");
                thorX += 1;
                thorY += 1;
            }
            
            else if(thorX > lightX & thorY < lightY){
                Console.WriteLine("SW");
                thorX -= 1;
                thorY += 1;
            }
            
            else if(thorX < lightX & thorY > lightY){
                Console.WriteLine("NE");
                thorX += 1;
                thorY -= 1;
            }
            
            else if(thorX > lightX & thorY > lightY){
                Console.WriteLine("NW");
                thorX -= 1;
                thorY -= 1;
            }
            
            else if(thorX < lightX){
                Console.WriteLine("E");
                thorX += 1;
            }
            
            else if(thorX > lightX){
                Console.WriteLine("W");
                thorX -= 1;
            }
            
            else if(thorY < lightY){
                Console.WriteLine("S");
                thorY += 1;
            }
            
            if(thorY > lightY){
                Console.WriteLine("N");
                thorY -= 1;
            }
        }
    }
}