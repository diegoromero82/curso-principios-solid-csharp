using System;
using System.Collections.Generic;

namespace OpenClose2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciamos las estrategias de cálculo (calculadoras)
            ISalaryCalculator contractorCalculator = new ContractorSalaryCalculator();
            ISalaryCalculator partTimeCalculator = new PartTimeSalaryCalculator();
            ISalaryCalculator fullTimeCalculator = new FullTimeSalaryCalculator();

            // 2. Creamos los empleados usando una ÚNICA clase concreta (Employee), 
            // inyectándole la estrategia de salario correspondiente a cada uno.
            var employees = new List<Employee>
            {
                new Employee("Juan Pérez", 160, contractorCalculator),
                new Employee("María Gómez", 170, partTimeCalculator),
                new Employee("Carlos López", 160, fullTimeCalculator)
            };

            // 3. Recorremos la lista e imprimimos el salario calculado
            Console.WriteLine("--- REPORTE DE NÓMINA ---\n");

            foreach (var employee in employees)
            {
                Console.WriteLine($"Empleado: {employee.Fullname}");
                Console.WriteLine($"Horas Trabajanadas: {employee.HoursWorked}");
                Console.WriteLine($"Salario Mensual: ${employee.GetMonthlySalary():N2}");
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadLine();
        }
    }
}