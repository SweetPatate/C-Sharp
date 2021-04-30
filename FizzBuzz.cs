using System;
using System.Collections.Generic;

class FizzBuzz
{
    static void Main(string[] args)
    {
        List<int> collection = new List<int>() { 1, 2, 5, 7, 8, 10 }; ;

        foreach (int x in collection)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (x % 5 == 0)
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
