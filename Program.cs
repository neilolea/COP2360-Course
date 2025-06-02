using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*** Division Program ***");
        Console.WriteLine();

        string continueProgram = "yes";

        while (continueProgram == "yes")
        {
            Console.Write("First number: ");
            string firstNum = Console.ReadLine();

            Console.Write("Second number: ");
            string secondNum = Console.ReadLine();

            // Math
            try
            {
                int num1 = Convert.ToInt32(firstNum);
                int num2 = Convert.ToInt32(secondNum);

                int answer = num1 / num2;

                Console.WriteLine();
                Console.WriteLine("Answer: " + answer);

                // decimals
                double decimalAns = (double)num1 / (double)num2;
                Console.WriteLine("With decimals: " + decimalAns);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Error! You need to type numbers!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Error! Can't divide by 0!");
            }
            catch (OverflowException)
            {
                // Tests for big nums
                Console.WriteLine();
                Console.WriteLine("Error! Number too big!");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Something went wrong: " + ex.Message);
            }

            Console.WriteLine();
            Console.Write("Continue? (yes/no): ");
            continueProgram = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Bye!");
    }
}