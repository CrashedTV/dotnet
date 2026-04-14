// //Control Flow Practice Plans

/* 1. Write a program that prints a multiplication table for any number entered by the user (e.g., 7 × 1
 through 7 × 10). */

// int num = 7;
Console.WriteLine("Enter number you want to print:");
int num = int.Parse(Console.ReadLine());
int multiply;
for (int i = 1; i <= 10; i++)
{
    multiply = num * i;
    Console.WriteLine($"{num} * {i} = {multiply}");
}



/* 2. Use a switch statement: ask the user to enter a season number (1=Spring, 2=Summer, 3=Autumn,
 4=Winter) and print the season name and its typical activities.*/

Console.WriteLine("Enter a season number (1-4)");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Spring");
        break;
    case 2:
        Console.WriteLine("Summer");
        break;
    case 3:
        Console.WriteLine("Autumn");
        break;
    case 4:
        Console.WriteLine("Winter");
        break;
    default:
        Console.WriteLine("Invalid Input. Please choose between 1 and 4");
        break;
}


// 3. Use a while loop to simulate a bank ATM: start with a balance of Rs 10,000. Let the user withdraw
// money repeatedly until the balance is 0 or they choose to exit.

int balance = 10000;
while (balance > 0)
{
    Console.WriteLine("Enter the amount that you want to withdraw: ");
    int withdraw = int.Parse(Console.ReadLine());
    balance -= withdraw;
    if (balance <= 0)
    {
        Console.WriteLine($"You don't have {withdraw} balance in your account.");
        break;
    }
    Console.WriteLine($"Your remaining balance is: {balance}");

}


// 4. Print all numbers from 1 to 100 that are divisible by both 3 and 5 using a for loop and the modulus
// operator.
Console.WriteLine("The numbers that can be divisible by both 3 and 5 are: ");
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine(i);
    }

}