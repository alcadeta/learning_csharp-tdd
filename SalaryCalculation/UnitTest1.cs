using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTests
{
    /*
        To get hourly, divide annual salary by 2080
        eg. £100,006.40 / 2080 = £48.08

        To get annual, multiply hourly by 2080
        eg. £48.08 * 2080 = £100,006.40
    */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Step #1: Arrange
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            // Step #2: Act
            decimal annualSalary = salaryCalculator.GetAnnualSalary(50);

            // Step #3: Assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
