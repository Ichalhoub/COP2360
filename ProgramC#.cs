using System;

namespace DivisionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string num1Str = Console.ReadLine();
            
            Console.WriteLine("Enter second number:");
            string num2Str = Console.ReadLine();
            
            Divide(num1Str, num2Str);
        }
        
        static void Divide(string a, string b)
        {
            try
            {
                int num1 = Convert.ToInt32(a);
                int num2 = Convert.ToInt32(b);
                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format. Enter integers only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Number too large for int.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}