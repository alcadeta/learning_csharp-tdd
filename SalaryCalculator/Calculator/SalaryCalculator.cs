using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        private const int HOURS_IN_A_YEAR = 2080;

        public static decimal GetAnnualSalary(decimal hourlyWage)
        {
            var annualSalary = hourlyWage * HOURS_IN_A_YEAR;
            return annualSalary;
        }

        public static decimal GetHourlySalary(decimal annualSalary)
        {
            var hourlyWage = annualSalary / HOURS_IN_A_YEAR;
            return 0;
        }
    }
}