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
// 3. finally: To define a block of code to be executed, after try and catch blocks have been executed.
// 4. throw: To signal the occurrence of an exception during program execution.

// Syntax of Try-Catch Block
/*
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
*/


// Polymorphism




// Abstract Class ->    A class that cannot be instantiated and is meant to be subclassed. 
//                ->    It can contain abstract methods (without implementation) that must be implemented by derived classes, 
//                      as well as concrete methods (with implementation).
//                ->    It must be override.    
//                ->    We cannot create the object of abstract class but we can create the reference of abstract class and we can 
//                      refer the object of derived class.

// example of abstract class
/*
class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Circle(); // We can create reference of abstract class and refer the object of derived class
        shape.Draw(); // Output: Drawing a circle
    }
}
abstract class Shape
{
    public abstract void Draw(); // Abstract method
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
*/



// Interface ->    A contract that defines a set of methods and properties that a class must implement.
//           ->    It cannot contain any implementation, only method signatures and properties.
//           ->    A class can implement multiple interfaces, allowing for multiple inheritance of behavior.

// example of interface
class Program
{
    static void Main(string[] args)
    {
        IWorker worker = new Carpenter();
        worker.AcquireTools();
        worker.PerformTask();
        worker.ReleaseTools();
    }
}

public interface IWorkers
{
    void AcquireTools();
}
public interface IWorker
{
    void AcquireTools();
    void PerformTask();
    void ReleaseTools();

}

class Carpenter : IWorker, IWorkers
{
    public void AcquireTools()
    {
        Console.WriteLine("Carpenter acquiring tools");
    }

    public void PerformTask()
    {
        Console.WriteLine("Carpenter performing task");
    }

    public void ReleaseTools()
    {
        Console.WriteLine("Carpenter releasing tools");
    }
}