// 1. Create a 'Rectangle' class with private fields Width and Height, a parameterised constructor, public properties with validation (no negative values), and methods GetArea() and GetPerimeter().
namespace Assignment
{
  
  /*
    public class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get => _width; 
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width cannot be negative.");
                }
                else
                {
                    _width = value;
                }
            }
        }
        public double Height
        {
            get => _height; 
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height cannot be negative.");
                }
                else
                {
                    _height = value;
                }
            }
        }
        public double GetArea()
        {
            return Width * Height;
        }
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    
        public static void Main()
        {
            try
            {
                Rectangle rect1 = new Rectangle(5, 10);
                Console.WriteLine($"Area: {rect1.GetArea()}");
                Console.WriteLine($"Perimeter: {rect1.GetPerimeter()}");

                // This will throw an exception due to negative width
                Rectangle rect2 = new Rectangle(-3, 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


*/

// 2. Create a 'Person' class with Name, Age, Email. The Email property must validate that it contains '@'. If invalid, throw an exception.
// 3. Add a static field 'TotalObjects' to your Person class. Every time a Person is created, increment it. After creating 5 people, print the total count.
/*  
    class Person
    {
        private string _name;
        private int _age;
        private string _email;    
        public static int TotalObjects = 0;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

            TotalObjects++;
        }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name should not be empty.");
                }
                _name = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                _age = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email format. Email must contain '@'.");
                }
                _email = value;
            }
        }

        public static void Main()
        {
            try
            {
            Person person1 = new Person("Ayush Shrestha", 21, "ayush@gmail.com");
            Person person2 = new Person("Darshan Shrestha", 13, "darshan@gmail.com");
            Person person3 = new Person("Gaurab Shrestha", 22, "gaurab@gmail.com");
            Console.WriteLine($"Total Person: {TotalObjects}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }



*/

// 4. Create a 'Temperature' class that stores Celsius internally but has a computed property 'Fahrenheit' that converts it: F = (C × 9/5) + 32.


    class Temperature
    {
        private double _celsius{get; set;}
        public Temperature(double celsius)
        {
            if(celsius < -273.15)
            {
                throw new ArgumentException("Temperature cannot be less than absolute zero.");
            }
            _celsius = celsius;
        }
        public double Fahrenheit()
        {
            return (_celsius * 9 / 5) + 32;
        }
        public static void Main()
        {

            try
            {
                Temperature temperature = new Temperature(32);
                Console.WriteLine($"{temperature._celsius}°C is equal to {temperature.Fahrenheit()}°F");;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    
    }





// Create a BankAccount class with a private field _balance, a parameterized constructor, a public property with validation (no negative balance), and methods Deposit() and Withdraw() (no overdraft allowed), and test it in Main() using try-catch.
/*
    class BankAccount
    {
        private double _balance;

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public double Balance
        {
            get => _balance;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Deposit amount cannot be negative.");
                }
                _balance = value;
            }
        }
        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be greater than zero.");
            }
            _balance += amount;
        }     
        public void Withdraw(double amount)
        {
            if(amount > _balance)
            {
                throw new ArgumentException("Insufficient funds.");
            }
            _balance -= amount;
        }       
        public static void Main()
        {
            try
            {
            BankAccount account = new BankAccount(10000);
            account.Withdraw(500);
            Console.WriteLine($"Remaining balance: {account.Balance}");
            account.Deposit(200);
            Console.WriteLine($"Updated balance: {account.Balance}");
            account.Withdraw(15000); // This will throw an exception due to insufficient funds
            Console.WriteLine($"Remaining balance: {account.Balance}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
*/



// Create a Employee class with:
// private fields:
// _name
// _salary
// parameterized constructor
// public properties with validation:
// Name → empty or null हुन नहुने
// Salary → negative हुन नहुने
// method:
// GetAnnualSalary() → salary × 12 return गर्ने
// GiveBonus(double percent) → salary increase गर्ने
// test in Main() using try-catch

/*
    class Employee
    {
        private string _name;
        private double _salary;
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary; 
        }    

        public string Name
        {
            get => _name;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _name = value;
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                _salary = value;
            }
        }

        public double GetAnnualSalary()
        {
            return _salary * 12;
        }
        public void GiveBonus(double percent)
        {
            _salary += _salary * percent / 100;
        }

        public static void Main()
        {
            try
            {
                Employee employee = new Employee("Ayush Shrestha", 18500.69);
                Console.WriteLine($"Annual Salary of {employee.Name} is {employee.GetAnnualSalary()}");
                employee.GiveBonus(10);
                Console.WriteLine($"Salary after bonus of {employee.Name} is {employee.Salary}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

    }

*/



}





