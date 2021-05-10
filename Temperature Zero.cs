using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
Write a program that displays the temperature closest to 0 from the input data. 
If two numbers are equally close to zero, then the positive integer will be taken as being closer to zero
(for example, if the temperatures are -5 and 5, then display 5).
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        
        int answer = 5527; // The max integer ranging
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]); // A temperature expressed as an integer ranging from -273 to 5526
            if (Math.Abs(t) < Math.Abs(answer)){ // get absolute value of the temperature and take the lower
                answer = t;
            }
            else if (Math.Abs(t) == Math.Abs(answer) && t > answer){ //if absolute t == absolute reponse and t is positif
                answer = t;
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if(n == 0){
            Console.WriteLine(0);
        }
        else{
            Console.WriteLine(answer);
        }
    }
}