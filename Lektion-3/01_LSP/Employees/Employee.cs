namespace _01_LSP.Employees
{
    internal class Employee
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public virtual int HourlySalary { get; set; } = 150;
        public Employee? Manager { get;  private set; }

        public void GetMonthlySalary()
        {
            Console.WriteLine($"{FirstName} {LastName} har {(HourlySalary * 167).ToString("N")} i månadslön.");
        }

        public void GetYearlySalary()
        {
            Console.WriteLine($"{FirstName} {LastName} har {((HourlySalary * 167) * 12).ToString("N")} i årslön. \n");
        }

        public virtual void AssignManager(Employee? manager)
        {
            try { Manager = manager; }
            catch { }
            
            Console.WriteLine($"{FirstName} {LastName} har {Manager?.FirstName} {Manager?.LastName} som sin närmaste chef.");
        }
    }
}
