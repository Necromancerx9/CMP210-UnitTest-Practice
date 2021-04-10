using System;

namespace EmployeeManagement
{
    public class EmployeeService
    {
        private const decimal BASIC_SALARY = 10000000;

        public static decimal CalculateSalary(EmployeeType employeeType, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Years of experience is not valid");
            }

            decimal factor = 0;

            switch (employeeType)
            {
                case EmployeeType.Engineer:
                    factor = 1;
                    break;
                case EmployeeType.SeniorEngineer:
                case EmployeeType.Manager:
                    factor = 1.5m;
                    break;
                case EmployeeType.SeniorManager:
                    factor = 2;
                    break;
                case EmployeeType.Expert:
                    factor = 2.8m;
                    break;
            }
            
            var allowance = 0
                
            if (years >= 5 && (employeeType == EmployeeType.SeniorManager || employeeType == EmployeeType.Expert)) {
                allowance = BASIC_SALARY * 0.2m;
            } else if (years > 3) {
                allowance = BASIC_SALARY * 0.1m;
            }

            var salary = BASIC_SALARY * years * factor + allowance;

            return salary;
        }
    }
}
