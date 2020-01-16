namespace EmployeeBuilderFluentApp
{
    public interface IEmployeeInfoBuilder
    {
        IEmployeePositionBuilder SetName(string name);
    }
}