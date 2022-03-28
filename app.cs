using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Ran = rnd.Next(1, 100);
            int Ran1 = rnd.Next(1, 100);
            int score = 0;
            int stageAnswer = Ran + Ran1;
            Console.WriteLine("Let's test your math skills!");
            Console.WriteLine("You are required to add a random integer to a random number and see how far you get!");
            Console.WriteLine("The randmon number is " + Ran + ", and the interger you must add each time is " + Ran1 + ".");
            while (1 == 1)
            {
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == stageAnswer)
                {
                    do
                    {
                        score = score + 1;
                        Console.WriteLine("Your current score is " + score + ". Press 'Enter' and then type your next answer");
                        stageAnswer = stageAnswer + Ran1;
                    }
                    while (userAnswer == stageAnswer);
                }

                else
                {
                    Console.WriteLine("Sorry, that's wrong. Thanks for playing");
                    Console.WriteLine("Your final score is " + score);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
