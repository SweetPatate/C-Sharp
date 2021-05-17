using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
https://www.codingame.com/ide/puzzle/ascii-art
ASCII art allows to represent shapes by using characters. In our case, these shapes are precisely words.

Your mission: Write a program capable of displaying a line of text in ASCII art in a style provided to you as input.

 #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### 
# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # 
### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## 
# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       
# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine()); // the width L of a letter represented in ASCII art. All letters are the same width.
        int H = int.Parse(Console.ReadLine()); // the height H of a letter represented in ASCII art. All letters have the same height.

        string T = Console.ReadLine().ToUpper(); // The text line T, consisting of N ASCII characters
        const int A = (int) 'A';
        const int Z = (int) 'Z';

        for (int i = 0; i < H; i++) {
            string row = Console.ReadLine(); // The représentation ASCII
            string retain = "";

            foreach (var s in T) {
                var character = (int) s;

                if (character < A || character > Z)
                    retain+= row.Substring(L * (Z - A + 1), L);
                else
                    retain+= row.Substring(L * (character - A), L);
            }
            Console.WriteLine(retain);
        }
    }
}