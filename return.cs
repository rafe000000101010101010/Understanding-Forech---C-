using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        /*    {
        int num01;
        int num02;

        Console.Write("num01: ");
        num01 = int.Parse(Console.ReadLine());
        Console.Write("num02: ");
        num02 = int.Parse(Console.ReadLine());          //firts to understand
        
        int result = Addition(num01, num02);
        Console.WriteLine("Answer: "result);
        Console.ReadKey();
    }

    static int Addition(int num01, int num02)
    {
        int result = num01 + num02;

        return result;
    } */
        /*   int num01;
           int num02;
   
           Console.Write("num01: ");
           num01 = int.Parse(Console.ReadLine());              //second to understand
           Console.Write("num02: ");
           num02 = int.Parse(Console.ReadLine());
   
           string result = Addition(num01, num02);
           Console.WriteLine(result);
           Console.ReadKey();
       }
   
       static string Addition(int num01, int num02)
       {
           int result = num01 + num02;
   
           return $"Answer is: {result}";
       }
   }*/

        /* int num01;
         int num02;
 
         Console.Write("num01: ");
         num01 = int.Parse(Console.ReadLine());
         Console.Write("num02: ");
         num02 = int.Parse(Console.ReadLine());
 
         int result = Addition(num01, num02);
         Console.WriteLine(result);
         Console.ReadKey();
     }
 
     static int Addition(int num01, int num02)
     {
         if (num01 > num02)
         {
             int result = num01 + num02;
             return result;
         }
         else
         {
             int result = num01 - num02;
             return result;
         }
     }
 }*/
        Addition(5, 3);
        Console.ReadKey();
    }

    static void Addition(int num01, int num02)
    {
        if (num01 > num02)
        {
            return;
        }

        Console.WriteLine("You are succesfull!");
    }
}
