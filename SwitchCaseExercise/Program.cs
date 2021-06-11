using System;

namespace SwitchCaseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("I have never liked this subject!");
                    break;

                case "English":
                    Console.WriteLine("I never really excelled at this subject.");
                    break;

                case "Science":
                    Console.WriteLine("I have a love/hate relationship with science.");
                    break;

                case "Art":
                    Console.WriteLine("I was very good at drawing growing up.");
                    break;

                case "P.E.":
                    Console.WriteLine("I always excelled at doing physical exercises!");
                    break;

                default:
                    Console.WriteLine("I guess you don't like school.");
                        break;

            }
        }   

    }
}
