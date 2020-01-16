namespace EmployeeBuilderFluentApp
{
    public interface IEmployeeSalaryBuilder
    {
        IEmployeeBuilder WithSalary(double salary);
    }
}