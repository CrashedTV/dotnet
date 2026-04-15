using System;
// Methods and Functions
// Funtion Definition, Paramters, Arguments, 
// Return Type, Void, Method Overloading, Recursion
// out and ref parameters (...)

// 1. Methods (Parameteres Return Types, Overloading)
// Syntax:
// AccessModifier ReturnType MethodName(ParameterList)

// int Add(int a, int b)
// {
//     return a + b;
// }
// int result = Add(5, 10);
// Console.WriteLine(result); // Output: 15


// //void without parameters
// void PrintMessage()
// {
//     Console.WriteLine("Hello!");
// }

// // void
// void PrintMessage(string name)
// {
//     Console.WriteLine($"Hello, {name}!");
// }

// PrintMessage();
// PrintMessage("World"); 

// // Recursion 
// int Factorial(int n)
// {
//     if (n == 0 || n == 1)
//     {
//         return 1;
//     }
//     else
//     {
//         return n * Factorial(n - 1);
//     }
// }
// int result = Factorial(5);
// Console.WriteLine($"Factorial is: {result}");

// Static Method -> Extension Method
namespace Day4
{
    public static class MyExtension
    {
        public static string ConcatName(this string personName)
        {
                return personName + " is a student.";
        }
        class Program
        {
            static void Main(string[] args)
            {
                string name = "John";
                string result = name.ConcatName();
                Console.WriteLine(result);
            }
        }
    }
}