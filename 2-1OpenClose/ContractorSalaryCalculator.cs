namespace OpenClose2
{
    public class ContractorSalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateSalary(int hoursWorked)
        {
            decimal hourValue = 20000M;
            return hourValue * hoursWorked;
        }
    }
}