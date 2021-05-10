using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
https://www.codingame.com/ide/puzzle/shadows-of-the-knight-episode-1
Avant chaque saut, le détecteur fournira à Batman la direction des bombes par rapport à la position actuelle de Batman:
U (Up : les bombes sont situées au dessus de Batman)
UR (Up-Right : les bombes sont situées au dessus et à droite de Batman)
R (Right : les bombes sont situées à droite de Batman)
DR (Down-Right : les bombes sont situées en dessous et à droite de Batman)
D (Down : les bombes sont situées en dessous de Batman)
DL (Down-Left : les bombes sont situées en dessous et à gauche de Batman)
L (Left : les bombes sont situées à gauche de Batman)
UL (Up-Left : les bombes sont situées au dessus et à gauche de Batman)

Votre mission consiste à programmer le détecteur afin qu'il indique la position de la fenêtre sur laquelle Batman devra se rendre au saut suivant de sorte qu'il atteigne les bombes le plus tôt possible.
Les bâtiments sont représentés par des rectangles de fenêtres, la fenêtre en haut à gauche a pour position (0,0).
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X = int.Parse(inputs[0]);
        int Y = int.Parse(inputs[1]);

        int x1 = 0;
        int y1 = 0;
        int x2 = W - 1;
        int y2 = H - 1;
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)            
            
            if (bombDir.Contains("U")) {
                y2 = Y - 1;
            }
            
            else if (bombDir.Contains("D")) {
                y1 = Y + 1;
            }
        
            if (bombDir.Contains("L")) {
                x2 = X - 1;
            }
            
            else if (bombDir.Contains("R")) {
                x1 = X + 1;
            }
            
            X = x1 + (x2 - x1) / 2;
            Y = y1 + (y2 - y1) / 2;
            //the location of the next window Batman should jump to.
            Console.WriteLine(X + " " + Y);
        }
    }
}