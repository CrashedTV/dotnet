// 1. Write a method 'int Square(int n)' that returns n squared. Call it from Main.
namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int Square(int n)
            {
                return n * n;
            }
            int result = Square(num);
            Console.WriteLine($"Square is: {result}");
        }
    }
}


// 2. Write an overloaded method 'string Describe(int n)' and 'string Describe(double n)' — each returns a sentence describing the number.

// 3. Write a recursive method 'int SumUpTo(int n)' that returns the sum of all numbers from 1 to n. Verify: SumUpTo(5) = 15.

// 4. Write a method that takes a string and uses a for loop to count how many vowels (a, e, i, o, u) it contains. Return that count.