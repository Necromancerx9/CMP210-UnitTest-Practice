using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmployeeManagement;
namespace EmployeeManagement.UnitTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        const decimal BASIC_SALARY = 10000000;
        [TestMethod]
        public void CalculateSalaryEngineerTestSuccess()
        {
            // Arrange
            EmployeeType employeeType = EmployeeType.Engineer;
            var years = 4;
            var years2 = 2;
            var factor = 1m;

            // Act
            var salaryYear4 = EmployeeService.CalculateSalary(employeeType, years);
            var salaryYear2 = EmployeeService.CalculateSalary(employeeType, years2);
            // Assert

            Assert.AreEqual(salaryYear4, BASIC_SALARY * years * factor + BASIC_SALARY * 0.1m);
            Assert.AreEqual(salaryYear2, BASIC_SALARY * years2 * factor);
        }

        // TODO Write more unit test to test all possible cases
        [TestMethod]
        public void CalculateSalarySeniorEngineerTestSuccess()
        {
            // Arrange
            EmployeeType employeeType = EmployeeType.SeniorEngineer;
            var years = 4;
            var years2 = 2;
            var factor = 1.5m;

            // Act
            var salaryYear4 = EmployeeService.CalculateSalary(employeeType, years);
            var salaryYear2 = EmployeeService.CalculateSalary(employeeType, years2);
            // Assert

            Assert.AreEqual(salaryYear4, BASIC_SALARY * years * factor + BASIC_SALARY * 0.1m);
            Assert.AreEqual(salaryYear2, BASIC_SALARY * years2 * factor);
        }

        [TestMethod]
        public void CalculateSalaryManagerTestSuccess()
        {
            // Arrange
            EmployeeType employeeType = EmployeeType.Manager;
            var years = 4;
            var years2 = 2;
            var factor = 1.5m;

            // Act
            var salaryYear4 = EmployeeService.CalculateSalary(employeeType, years);
            var salaryYear2 = EmployeeService.CalculateSalary(employeeType, years2);
            // Assert

            Assert.AreEqual(salaryYear4, BASIC_SALARY * years * factor + BASIC_SALARY * 0.1m);
            Assert.AreEqual(salaryYear2, BASIC_SALARY * years2 * factor);
        }

        [TestMethod]
        public void CalculateSalarySeniorManagerTestSuccess()
        {
            // Arrange
            EmployeeType employeeType = EmployeeType.SeniorManager;
            var years = 2;
            var years2 = 4;
            var years3 = 6;
            var factor = 2m;

            // Act
            var salaryYear6 = EmployeeService.CalculateSalary(employeeType, years3);
            var salaryYear4 = EmployeeService.CalculateSalary(employeeType, years2);
            var salaryYear2 = EmployeeService.CalculateSalary(employeeType, years);
            // Assert

            Assert.AreEqual(salaryYear6, BASIC_SALARY * years3 * factor + BASIC_SALARY * 0.2m);
            Assert.AreEqual(salaryYear4, BASIC_SALARY * years2 * factor + BASIC_SALARY * 0.1m);
            Assert.AreEqual(salaryYear2, BASIC_SALARY * years * factor);
        }

        [TestMethod]
        public void CalculateSalaryExpertTestSuccess()
        {
            // Arrange
            EmployeeType employeeType = EmployeeType.Expert;
            var years = 2;
            var years2 = 4;
            var years3 = 6;
            var factor = 2.8m;

            // Act
            var salaryYear6 = EmployeeService.CalculateSalary(employeeType, years3);
            var salaryYear4 = EmployeeService.CalculateSalary(employeeType, years2);
            var salaryYear2 = EmployeeService.CalculateSalary(employeeType, years);
            // Assert

            Assert.AreEqual(salaryYear6, BASIC_SALARY * years3 * factor + BASIC_SALARY * 0.2m);
            Assert.AreEqual(salaryYear4, BASIC_SALARY * years2 * factor + BASIC_SALARY * 0.1m);
            Assert.AreEqual(salaryYear2, BASIC_SALARY * years * factor);
        }
    }
}
