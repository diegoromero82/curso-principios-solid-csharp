namespace OpenClose2
{
    public class FullTimeSalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateSalary(int hoursWorked)
        {
            decimal hourValue = 30000M;
            return hourValue * hoursWorked;
        }
    }
}