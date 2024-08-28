namespace BackgroundVerify.Interface
{
    public interface IEmployeeService
    {
        bool VerifyEmployment(int employeeId, string companyName, string verificationCode);
    }
}
