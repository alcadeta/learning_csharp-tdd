using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        private const int HOURS_IN_A_YEAR = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage) =>
            hourlyWage * HOURS_IN_A_YEAR;

        public decimal GetHourlyWage(decimal annualSalary) =>
            annualSalary / HOURS_IN_A_YEAR;
    }
}