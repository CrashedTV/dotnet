// 1. Create a program that takes user input for age and throws a custom exception if age is less than 18, then handle it gracefully.
namespace Assignment
{
    class Program
    {
        public static void CheckAge()
        {
             try
            {
                Console.WriteLine("Enter you age: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("You are underage and not eligible.");
                }
                else
                {
                    Console.WriteLine("Welcome! You are eligible.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Main(string[] args)
        {
           CheckAge();
        }
    }
}

// 2. Write a program with an Animal class and derived classes (Dog, Cat) where each overrides a sound() method and test polymorphism with a loop.
// 3. Design an abstract class Shape with an abstract method calculateArea() and create concrete classes Circle and Rectangle that implement it.
// 4. Create a bank system where withdraw() method throws custom exceptions (InsufficientFunds, InvalidAmount) for different account types (SavingsAccount, CurrentAccount).
// 5. Build a payment system with an abstract Payment class and derived classes (CreditCard, UPI, Cash) where each implements processPayment() with proper exception handling for invalid inputs.