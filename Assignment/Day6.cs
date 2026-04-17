// 1. Create a program that takes user input for age and throws a custom exception if age is less than 18, then handle it gracefully.
namespace Assignment
{
    /*  
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
                    throw new Exception("You are not eligible.");
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
    */

// 2. Write a program with an Animal class and derived classes (Dog, Cat) where each overrides a sound() method and test polymorphism with a loop.
/*
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
    public static void Main(string[] args)
        {
            Animal a1 = new Dog();
            Animal a2 = new Cat();

            a1.Sound();
            a2.Sound();
        }

    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows");
        }
    }
*/

// 3. Design an abstract class Shape with an abstract method calculateArea() and create concrete classes Circle and Rectangle that implement it.
/*
    public abstract class Shape
    {
        abstract public void calculateArea();
        public static void Main(string[] args)
        {
            Shape s1 = new Circle(10);
            Shape s2 = new Rectangle(4, 6);

            s1.calculateArea();
            s2.calculateArea();
        }
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override void calculateArea()
        {
            double circumference = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle: {circumference}");
        }
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public override void calculateArea()
        {
            double area = width * height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
*/

// 4. Create a bank system where withdraw() method throws custom exceptions (InsufficientFunds, InvalidAmount) for different account types (SavingsAccount, CurrentAccount).
    // public class BankSystem
    // {
    //     protected double balance;
    //     public BankSystem(double bal)
    //     {
    //         balance = bal;
    //     }
    //     public abstract void withdraw(double amount);
    // }

// 5. Build a payment system with an abstract Payment class and derived classes (CreditCard, UPI, Cash) where each implements processPayment() with proper exception handling for invalid inputs.
    public abstract class Payment
    {
        protected double amount;
        public abstract void processPayment(double amount);
        public static void Main(string[] args)
        {
            try
            {
                CreditCard cc = new CreditCard();
                Cash cash = new Cash();
                UPI upi = new UPI();
                cc.processPayment(1000);
                cash.processPayment(500);
                upi.processPayment(-200);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class CreditCard : Payment
    {
        public override void processPayment(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid amount for credit card payment.");
            }
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class UPI : Payment
    {
        public override void processPayment(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid amount for UPI payment.");
            }
            Console.WriteLine($"Processing UPI payment of {amount}");
        }
    }
    public class Cash : Payment
    {
        public override void processPayment(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid amount for cash payment.");
            }
            Console.WriteLine($"Processing cash payment of {amount}");
        }
    }
    
}


