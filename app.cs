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
            Random rnd1 = new Random();
            int Ran1 = rnd1.Next(1, 100);
            int score = 0;
            int next = 0;
            Console.WriteLine("Let's test your math skills!");
            Console.WriteLine("You are required to add a random integer to a random number and see how far you get!");
            Console.WriteLine("The randmon number is " + Ran + ", and the interger you must add by is " + Ran1 + ".");
            while (1==1)
            {
               int stageAnswer = Ran + Ran1;
               int userAnswer = Convert.ToInt32(Console.ReadLine());
               if ((userAnswer > stageAnswer) || (userAnswer < stageAnswer))
               {
                   break; 
               }
               else 
               {
                   score++;
                   Console.WriteLine(score);
               }
               do
               {
               stageAnswer = stageAnswer + Ran1; 
               }
               while (1==2);
               Console.ReadLine(); 
            }
        }
    }
}
