using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        private const int HOURS_IN_A_YEAR = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            var annualSalary = hourlyWage * HOURS_IN_A_YEAR;
            return annualSalary;
        }

        public decimal GetHourlyWage(decimal annualSalary)
        {
            var hourlyWage = annualSalary / HOURS_IN_A_YEAR;
            return hourlyWage;
        }
    }
}