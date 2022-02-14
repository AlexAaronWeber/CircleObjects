using System;
namespace CircleObjects
{
	public class Validator
	{
        //methods for program


        //get continue 
        public static bool GetContinue()
        {
            bool result = true;

            while (true)
            {
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
            return result;
        }

        public static double GetUserRadius()
        {
            double input = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter a radius: ");
                    input = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return input;
        }
    }
}

