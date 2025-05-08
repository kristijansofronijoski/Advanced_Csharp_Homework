

namespace Task_04
{
    public class Programmer : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programmer(string name, int id, double hourlyRate, int hoursWorked)
            : base(name, id)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Programmer Info:");
            Console.WriteLine($"Name: {Name}, ID: {ID}, Salary: {CalculateSalary()}");
        }
    }
}