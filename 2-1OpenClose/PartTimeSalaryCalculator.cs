namespace OpenClose2
{
    public class PartTimeSalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateSalary(int hoursWorked)
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * hoursWorked;

            if (hoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraHours = hoursWorked - 160;
                salary += effortCompensation * extraHours;
            }

            return salary;
        }
    }
}