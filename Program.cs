using System;
using System.Collections.Concurrent;

class Program
{
    public int i;

    public static int right = 0;
    public static int wrong = 0;

    static void Main()
    {
        Console.Title = "Genius Calculator";
        Console.WriteLine(
            "Hey, you genius sign here. I know you are the best. \nYou are better than anyone in the world. \nNo one can beat you in any competition! \nYou are the no.1. \nNo one not even born to beat also never born in future."
        );
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write("Name:");
        string You = Convert.ToString(Console.ReadLine());
        Console.Write("Competitor:");
        string Enemy = Convert.ToString(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        int alien = 5;
        int i = 0;

        while (i < alien)
        {
            Random rand = new Random(); // Initialize a new instance of the Random class

            int min = 1;
            int max = 10;
            int randomNum = rand.Next(min, max);
            Random Xrand = new Random(); // Initialize a new instance of the Random class

            int Xmin = 1;
            int Xmax = 10;
            int XandomNum = Xrand.Next(Xmin, Xmax);

            Console.WriteLine($"{randomNum} - {XandomNum} = ?");
            Console.Write("Ans: ");

            int Ans = Convert.ToInt32(Console.ReadLine());
            int result = randomNum - XandomNum;

            if (result == Ans)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string correct = "You are correct!";
                Console.WriteLine(correct);
                Console.ForegroundColor = ConsoleColor.White;
                right += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string Incorrect = $"You are incorrect!. Correct answer is {result}";
                Console.WriteLine(Incorrect);
                Console.ForegroundColor = ConsoleColor.White;

                wrong += 1;
            }

            ++i;
        }
        Random Irand = new Random(); // Initialize a new instance of the Random class

        int Imin = 1;
        int Imax = 235;
        int IrandomNum = Irand.Next(Imin, Imax);
        Random Zrand = new Random();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Statisctic: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Correct: {right}");
        Console.WriteLine($"Incorrect: {wrong}");
        int avg = right / i;

        Console.WriteLine($"Avarage: {avg}/{i}");
        int toapa;
        toapa = Convert.ToInt32(Irand);

        Console.WriteLine($"IQ : {toapa}");

        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n{You} vs {Enemy}:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(
            $"{Enemy}'s IQ is {toapa - 199}. Congratulation! you are 2.75% better than {Enemy}"
        );
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(
            $"{You} is now officially better than Albert Einstain!.\nHere is you certificate!"
        );
        Console.ReadKey();
    }
}
