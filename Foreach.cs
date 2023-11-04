using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        string[] name = { "Shakib ", "Miraz ", "Mahmudullah ", "Mushfiqur " };
        foreach (var Cricketer in name)
        {
            Console.Write(Cricketer);
        }
        Console.ReadKey();
    }
}
