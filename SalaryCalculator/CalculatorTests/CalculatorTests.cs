using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // 1. Arrange
            var sc = new SalaryCalculator();

            // 2. Act
            var annualSalary = SalaryCalculator.GetAnnualSalary(50);

            // 3. Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void HourlySalaryTest()
        {
            // 1. Arrange
            var sc = new SalaryCalculator();

            // 2. Act
            var hourlyWage = SalaryCalculator.GetHourlySalary(104000);

            // 3. Assert
            Assert.AreEqual(50, hourlyWage);
        }
    }
}