// control flow

/*
1. if else statement
2. switch statement
3. loops (for, while, do-while)
4. break and continue
*/

// if else statement example 
/*
    Console.WriteLine("Enter the traffic light color:");
    string trafficLight = Console.ReadLine().ToLower();

    if (trafficLight == "green")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You can go.");
    }
    else if (trafficLight == "yellow")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Get ready to stop.");
    }
    else if (trafficLight == "red")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You must stop.");
    }
    else
    {
        Console.WriteLine("Invalid traffic light color.");
    }
*/

// switch statement example
/*
Console.WriteLine("Enter the day of the week (1-7)");
string dayName;
int dayOfWeek = int.Parse(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        dayName = "Sunday";
        break;
    case 2:
        dayName = "Monday";
        break;
    case 3:
        dayName = "Tuesday";
        break;
    case 4:
        dayName = "Wednesday";
        break;
    case 5:
        dayName = "Thursday";
        break;
    case 6:
        dayName = "Friday";
        break;
    case 7:
        dayName = "Saturday";
        break;
    default:
        Console.WriteLine("Invalid day of the week.");
        break;
    
}
    Console.WriteLine($"You entered: {dayName}");    
*/


// For loop example
/*
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i;
}
Console.WriteLine($"The sum of the first 10 natural numbers is: {sum}");
*/

/*
int sum = 0;
Console.WriteLine("Enter a number to calculate its sum:");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine($"The sum of the first {number} natural numbers is: {sum}");
*/


//while loop example
/*
int count = 0;
while (count < 5)
{
    count++;
    Console.WriteLine($"Count: {count}");
}
*/

/*
Console.WriteLine("Enter a number to calculate its couunt:");
int number = int.Parse(Console.ReadLine());
int count = 0;
while (count < number)
{
    count++;
    Console.WriteLine($"Count: {count}");
}
*/

// do-while loop example

/*
int number = 5;
do
{
    number++;
    Console.WriteLine($"Number: {number}");
} while (number < 5);
*/


// array in foreach loop by taking user input for the array size
/*
Console.WriteLine("Enter the size of the array:");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Enter the elements of the array:");
foreach(int i in numbers)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("The elements of the array are:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
*/

// break and continue example
/*
string [] students = { "Alice", "Bob", "Charlie", "David", "Eve" };
Console.WriteLine("The students in the class are:");
for(int i = 0; i<students.Length; i++)
{
    if (students[i] == "Charlie")
    {
        Console.WriteLine("Charlie is absent today.");
        break; 
    }
    Console.WriteLine(students[i]);
}
*/

//continue example
Console.WriteLine("The odd numbers from 1 to 10 are:");
for(int i = 0; i <= 10 ; i++)
{
    if (i % 2 == 0)
    {
        continue; // skip the even numbers
    }
    Console.WriteLine(i);
}


// Methods and Functions
// Funtion Definition, Paramters, Arguments, 
// Return Type, Void, Method Overloading, Recursion