using System;
using System.Collections.Generic;

class FizzBuzz
{
    /*
    FizzBuzz :
    if the number is divisible by 3: write Fizz
    if the number is divisible by 5: we write Buzz
    if the number is divisible by 3 and by 5: write Fizzbuzz
    otherwise: write the number
    */

    static void Main(string[] args)
    {
        List<int> collection = new List<int>() { 1, 2, 3, 5, 7, 8, 10, 15, 16 }; ;

        foreach (int x in collection)
        {
            if (x % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (x % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else if (x % 3 != 0 & x % 5 != 0)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
}
