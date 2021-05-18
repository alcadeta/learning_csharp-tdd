using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        public static decimal GetAnnualSalary(decimal hourlyWage)
        {
            const int HOURS_IN_A_YEAR = 2080;
            var annualSalary = hourlyWage * HOURS_IN_A_YEAR;
            return annualSalary;
        }
    }
}