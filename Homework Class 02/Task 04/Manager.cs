
namespace Task_04
{
    public class Manager : Employee
    {
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public Manager(string name, int id, double baseSalary, double bonus)
            : base(name, id)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Manager Info:");
            Console.WriteLine($"Name: {Name}, ID: {ID}, Salary: {CalculateSalary()}");
        }
    }
}
