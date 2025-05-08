/*  
 Task 3:
Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter().
Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape.
 */

using Task_03;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");
        Shape triangle = new Triangle(3, 5, 5);
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
        Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()}");
    }
}