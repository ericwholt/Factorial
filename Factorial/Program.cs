using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                bool invalidInteger = true;
                string userInput = "";
                int usersChoice = 0;
                while (invalidInteger)
                {
                    //Prompt for user to enter an integer between 0 and 10
                    userInput = GetUserInput("Enter an integer that's greate than 0 but less than 10: ");

                    //Validate string is an integer, is positive, and between 0 and 10
                    invalidInteger = IsStringAnInnvalidInteger(userInput);//End loop if it is a valid integer.
                    if (!invalidInteger)
                    {
                        usersChoice = int.Parse(userInput);

                    }

                }
                Console.WriteLine("The factorial of {0} is {1}", usersChoice, CalculateFactorial(usersChoice));
                if (GetUserInput("Continue (y/n)") == "n")
                {
                    break;
                }

            }
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.Write("Press Any Key...");
            Console.ReadKey();//Keep console from closing immediately

        }

        /// <summary>
        /// Method to display message and get input from user.
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>User input as string.</returns>
        static string GetUserInput(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Validates userinput is an integer and returns a bool
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <returns>Returns false if integer or false if it is not</returns>
        static bool IsStringAnInnvalidInteger(string stringToValidate)
        {
            //Check string is a integer with Tryparse. If it is then save it to local int integer.
            if (int.TryParse(stringToValidate, out int integer))
            {
                //We have a valid integer. Check if it is between 0 and 10
                if (integer > 0 && integer < 10)
                {
                    return false; //All conditions pass the integer is valid
                }
            }
            Console.WriteLine("You must enter a number between 0 and 10");
            return true;
        }
        public static int CalculateFactorial(int factorial)
        {
            if (factorial == 1)
            {
                return 1;
            }
            else
            {
                return factorial * CalculateFactorial(factorial - 1);
            }
        }
    }
}
