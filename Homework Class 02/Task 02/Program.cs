/* 
 Task 2
Write a program to create an interface Shape with the GetArea() method. Create three classes Rectangle, Circle, and Triangle that implement the Shape interface.
Implement the GetArea() method for each of the three classes.
 */

using Task_02.Interfaces;
using Task_02;

class Program
{  static void Main()
    {
        IShape rectangle = new Rectangle(5, 10);
        IShape circle = new Circle(7);
        IShape triangle = new Triangle(6, 8);

        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine($"Triangle area: {triangle.GetArea()}");
    } }