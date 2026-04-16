// 1. Create a 'Rectangle' class with private fields Width and Height, a parameterised constructor, public properties with validation (no negative values), and methods GetArea() and GetPerimeter().
namespace Assignment
{
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




// 2. Create a 'Person' class with Name, Age, Email. The Email property must validate that it contains '@'. If invalid, throw an exception.
// 3. Add a static field 'TotalObjects' to your Person class. Every time a Person is created, increment it. After creating 5 people, print the total count.
// 4. Create a 'Temperature' class that stores Celsius internally but has a computed property 'Fahrenheit' that converts it: F = (C × 9/5) + 32.











}