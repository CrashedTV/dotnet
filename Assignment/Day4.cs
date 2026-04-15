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


//// 2. Write an overloaded method 'string Describe(int n)' and 'string Describe(double n)' — each returns a sentence describing the number.
namespace Day4
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine(Describe(8));
           Console.WriteLine(Describe(8848.84));
       }

        static string Describe(int n)
       {
           return $"{n} is an integer.";
       }
        static string Describe(double n)
       {
           return $"{n} is a double number.";
       }
   }
}


// 3. Write a recursive method 'int SumUpTo(int n)' that returns the sum of all numbers from 1 to n. Verify: SumUpTo(5) = 15.
namespace Day4
{
   class Program
   {
       static void Main(string[] args)
       {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int SumUpTo(int n)
            {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n + SumUpTo(n - 1);
            }
            }
            int result = SumUpTo(num);
            Console.WriteLine($"Sum up to {num} is: {result}");
       }
   }
}
// 4. Write a method that takes a string and uses a for loop to count how many vowels (a, e, i, o, u) it contains. Return that count.
namespace Day4
{
   class Program
   {
       static void Main(string[] args)
       {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = char.ToLower(word[i]);

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of vowels in {word} is: {count}");
       }
   }
}