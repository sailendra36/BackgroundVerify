using BackgroundVerify.Interface;
using BackgroundVerify.Models;

namespace BackgroundVerify.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, CompanyName = "CompanyA", VerificationCode = "ABC123" },
            new Employee { EmployeeId = 2, CompanyName = "CompanyB", VerificationCode = "XYZ789" },
            new Employee { EmployeeId = 3, CompanyName = "CompanyC", VerificationCode = "DEF567" },
            new Employee { EmployeeId = 4, CompanyName = "CompanyD", VerificationCode = "MNO890" }
        };
        }

        public bool VerifyEmployment(int employeeId, string companyName, string verificationCode)
        {
            return _employees.Any(e => e.EmployeeId == employeeId && e.CompanyName == companyName && e.VerificationCode == verificationCode);
        }
    }
}
