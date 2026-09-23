namespace OpenClose2
{
    public class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        
        // Dependencia de la interfaz de cálculo
        private readonly ISalaryCalculator _salaryCalculator;

        // El constructor recibe los datos y la estrategia de salario correspondiente
        public Employee(string fullname, int hoursWorked, ISalaryCalculator salaryCalculator)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            _salaryCalculator = salaryCalculator;
        }

        // Delega la responsabilidad del cálculo a la clase que implementa la interfaz
        public decimal GetMonthlySalary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked);
        }
    }
}