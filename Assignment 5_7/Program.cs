using System;

class Program
{
    static void Main()
    {
        DivideNumbers();
    }

    static void DivideNumbers()
    {
        while (true)
        {
            try
            {
                
                Console.Write("Enter the numerator: ");
                double numerator = double.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                double denominator = double.Parse(Console.ReadLine());

               
                if (denominator == 0)
                {
                    throw new ArgumentException("Division by zero is not allowed. Please enter a non-zero denominator.");
                }

                
                double result = numerator / denominator;

                
                Console.WriteLine($"The result of {numerator} divided by {denominator} is: {result}");

               
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numerical values for numerator and denominator.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
        }
    }
}
