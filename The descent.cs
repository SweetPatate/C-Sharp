using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
https://www.codingame.com/ide/puzzle/the-descent
 * Rules
At the beginning of each game turn, you are given the height of each mountain from left to right.
Before the end of the game turn, you must indicate the highest mountain to shoot at.

Shooting at a mountain will only destroy part of it. Your ship goes down with each pass.
 
 
Victory conditions
You win if you destroy the highest mountain each turn.
 
Defeat conditions
Your ship hits a mountain
You provide an invalid exit or your program does not respond in time

 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int max = 0;
            int imax = 0;
            int montagneH = 0;
            for (int i = 0; i < 8; i++)
            {
                montagneH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                if (montagneH > max)
                {
                    max = montagneH;
                    imax = i;
                }
            }
            Console.WriteLine(imax); // The index of the mountain to fire on.
        }
    }
}
