/* 
 Task 4:
Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). 
Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to
calculate salary and display information for each role.
 */

using Task_04;

class Program
{
    static void Main()
    {
        Employee manager = new Manager("Mitre", 101, 5000, 1200);
        Employee programmer = new Programmer("Mirko", 102, 50, 160);

        manager.DisplayInfo();
        Console.WriteLine();
        programmer.DisplayInfo();
    }
}
