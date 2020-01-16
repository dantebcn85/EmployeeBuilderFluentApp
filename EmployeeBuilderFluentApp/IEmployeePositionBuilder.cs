namespace EmployeeBuilderFluentApp
{
    public interface IEmployeePositionBuilder
    {
        IEmployeeSalaryBuilder AtPosition(string position);
    }
}