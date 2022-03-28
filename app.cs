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
            int Ran = rnd.Next(1, 100); //Genereate first random integer
            int Ran1 = rnd.Next(1, 100); //Generate second random integer
            int score = 0; //Initialise score count
            int stageAnswer = Ran + Ran1; //Declare stage answer
            Console.WriteLine("Let's test your math skills!"); //First output text line (welcoming)
            Console.WriteLine("You are required to add a random integer to a random number and see how far you get!"); //Second output text line (instructions)
            Console.WriteLine("The randmon number is " + Ran + ", and the interger you must add each time is " + Ran1 + "."); //Third output text line (instructions2)
            while (1 == 1) // while (true)
            {
                int userAnswer = Convert.ToInt32(Console.ReadLine()); //Analyse answer and convert to integer
                if (userAnswer == stageAnswer) // If (correct answer (true))
                {
                    do // Do this at least once
                    {
                        score = score + 1; //Increment score
                        Console.WriteLine("The current value is " + stageAnswer); //Fourth output text line (display current numerical value)
                        Console.WriteLine("Add " + Ran1 + " to " + stageAnswer); //Fifth output text line (instructions3)
                        Console.WriteLine("Your current score is: " + score + ". Input your next answer, then press 'Enter'."); //Sixth output text line (CurrScore + Instructions4)
                        Console.WriteLine(); //Add blank line to make the program look nicer
                        stageAnswer = stageAnswer + Ran1; //Update correnct integer value
                    }
                    while (userAnswer == stageAnswer); // while (condition remains true)
                }

                else //if (condition becomes false)
                {
                    Console.WriteLine("Sorry, that's wrong. Thanks for playing"); //Seventh output (farewell)
                    Console.WriteLine("Your final score is " + score); //Final score declaration
                    break; //Break out
                }

            }
            Console.ReadLine(); //Analyse everything
        }
    }
}
