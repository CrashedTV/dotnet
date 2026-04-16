// 1. Exception Handling
// 2. Abstract Class
// 3. Interface


// Exception Handling
// ===========Types of Developer Exception============== 
// 1. NullReferenceException
// 2. DivideByZeroException
// 3. ArgumentOutOfRangeException
// 4. FormatException
// 5. ArgumentException

// ===========Types of System and Runtime Exception============== 
// 6. FileNotFoundException
// 7. IOException
// 8. OutOfMemoryException


// Krywords Action Purpose
// 1. try: To define a block of code to be tested for errors while it is being executed.
// 2. catch: To define a block of code to be executed, if an error occurs in the try block.
// 3. finally: To define a block of code to be executed, after try and
// 4. throw: To signal the occurrence of an exception during program execution.

// Syntax of Try-Catch Block
try
{
    // Code that may throw an exception
}
catch (ExceptionType1 ex)
{
    // Handle ExceptionType1
}
catch (ExceptionType2 ex)
{
    // Handle ExceptionType2
}
catch (Exception ex)
{
    // Handle any other exceptions
}
finally
{
    // Code that will always execute, regardless of whether an exception was thrown or caught
}