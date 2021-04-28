List<int> collection = new List<int>() { 1, 2, 5, 7, 8, 10 };;

foreach(int x in collection)
{
    if (x % 3 == 0)
    {
        Console.Write("Fizz");
    }
    if (x % 5 == 0)
    {
        Console.Write("Buzz");
    }
}