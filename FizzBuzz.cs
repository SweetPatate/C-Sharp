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
        for (int x=1; x<=100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
}