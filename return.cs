using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        int num01;
        int num02;

        Console.Write("num01: ");
        num01 = int.Parse(Console.ReadLine());
        Console.Write("num01: ");
        num02 = int.Parse(Console.ReadLine());

        int result = Addition(num01, num02);
        Console.WriteLine("Ans: " + result);
    }

    static int Addition(int num01, int num02)
    {
        int result = num01 + num02;

        return result;
    }
}
