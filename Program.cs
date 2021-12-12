using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> separator(string str)
        {
            List<int> thing = new List<int>();
            string[] splitted = str.Split(",");
            thing.Add(int.Parse(splitted[0]));
            thing.Add(int.Parse(splitted[1]));
            return thing;
        }
        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.Write("Give a range of numbers (ex. 0,99): ");
            string srange = Console.ReadLine();
            var range = separator(srange);
            int solution = rd.Next(range[0], range[1]);
            Console.WriteLine(solution);
            int guess;
            Console.Write($"Guess a number between {range[0]} and {range[1]}: ");
            guess = Convert.ToInt32(Console.ReadLine());
            while (guess != solution)
            {
                if (guess > solution)
                {
                    Console.WriteLine("The number you have guessed is Too High!");
                    Console.Write("Guess Again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else if (guess < solution)
                {
                    Console.WriteLine("The number you have guessed is Too Low!");
                    Console.Write("Guess Again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
            }
            Console.WriteLine("Hooray, you have guessed the number");
        }
    }
}