using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeeManagement.UnitTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        [TestMethod]
        public void CalculateSalaryEngineerTestSuccess()
        {
            // Arrange

            // Act
            var salary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 5);
            // Assert
            Assert.AreEqual(10, salary);
        }

        // TODO Write more unit test to test all possible cases
    }
}
