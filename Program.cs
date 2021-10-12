using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keeprunning = true;
            int whileCounter = 0;
            while (keeprunning == true)
            {
                whileCounter += 1;
                Console.Write("Welcome to the circle lab! ");
                double radius = GetNumber();
                Circle UserCircle = new Circle(radius);
                string circum = UserCircle.CalculateFormattedCircumference(radius);
                string area = UserCircle.CalculateFormattedArea(radius);
                Console.WriteLine($"Your circle has an circumference of {circum} and an area of {area}");
                keeprunning = TryAgain();
                if(keeprunning == false)
                {
                    Console.WriteLine($"Goodbye, you created {whileCounter} circles!");
                }
            }
                Console.ReadKey();
            }
        
        public static double GetNumber()
        {
            double numGiven;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a radius.");
                    numGiven = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("That was not a valid input, try again. ");
                }

            }
            return numGiven;
        }
        public static bool TryAgain()
        {
            bool validInput = false;
                bool yesOrNo = true;
                Console.WriteLine("Do you want to try with a different circle? ");
                string userAnswer;
            while (validInput == false)
            {
                try
                {
                    Console.WriteLine("yes or no.");
                    userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "yes")
                    {
                        validInput = true;
                        yesOrNo = true;
                    }
                    else if (userAnswer.ToLower() == "no")
                    {
                        yesOrNo = false;
                        validInput = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }
            return yesOrNo;
        }
    }
}
