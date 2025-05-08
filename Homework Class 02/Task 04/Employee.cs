

namespace Task_04
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}