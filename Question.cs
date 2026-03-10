namespace ConsoleApp7;

public class Question
{
    public static void q1()
    {
        Console.WriteLine("\n--- Q1: Abstraction vs Encapsulation ---");
        Console.WriteLine("1. Abstraction: Shows WHAT an object does (interface) while hiding HOW it works.");
        Console.WriteLine("2. Encapsulation: Wraps data and methods into one unit and RESTRICTS access to protect it.");
        Console.WriteLine("Example (Coffee Machine): Buttons (Espresso/Latte) are Abstraction. The internal casing protecting the heater is Encapsulation.");
    }

    public static void q2()
    {
        Console.WriteLine("\n--- Q2: Abstract Class vs Interface ---");
        Console.WriteLine("- Abstract Class: For 'Is-A' relationships, supports single inheritance, can have fields/logic.");
        Console.WriteLine("- Interface: For 'Can-Do' behaviors, supports multiple implementation, no instance fields.");
        Console.WriteLine("Choose Abstract Class for shared code between related types. Choose Interface for common behavior in unrelated types.");
    }

    public static void q3()
    {
        Console.WriteLine("\n--- Q3: Appliance Analysis ---");
        Console.WriteLine("a) No. Abstract classes cannot be instantiated because they are incomplete.");
        Console.WriteLine("b) PowerConsumption (Abstract): Must be implemented by child. Status (Virtual): Has default, can be overridden. Label (Concrete): Fixed logic for all.");
        Console.WriteLine("c) 'Standby'. Because Toaster does not override Status(), it uses the parent's default implementation.");
    }

    public static void q4()
    {
        Console.WriteLine("\n--- Q4: Partial & Extension Methods Analysis ---");

        // a) Partial Class
        Console.WriteLine("a) Partial Class: Allows a single class to be split into multiple files.");
        Console.WriteLine("   Why: To organize large classes or separate concerns (e.g., Logic in one file, Logging in another).");

        // b) Partial Method
        Console.WriteLine("b) Partial Method: A method defined in one partial file and optionally implemented in another.");
        Console.WriteLine("   If deleted: Yes, it will still compile. If no implementation exists, the compiler removes the call entirely.");

        // c) Extension Method
        Console.WriteLine("c) Extension Method: Adds new functionality to existing types without modifying their source code.");
        Console.WriteLine("   Rules: 1. Class must be static. 2. Method must be static. 3. First parameter must use 'this'.");

        // d) Output Prediction
        Console.WriteLine("d) Output:");
        Console.WriteLine("   Log: result = 20");
        Console.WriteLine("   $20.00                 " +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "" +
            "");
    }

}