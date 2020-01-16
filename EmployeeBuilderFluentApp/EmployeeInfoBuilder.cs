namespace EmployeeBuilderFluentApp
{
    public class EmployeeInfoBuilder<T> : EmployeePositionBuilder<EmployeeInfoBuilder<T>>, IEmployeeInfoBuilder where T : EmployeeInfoBuilder<T>
    {
        public T SetName(string name)
        {
            employee.Name = name;
            return (T)this;
        }

        IEmployeePositionBuilder IEmployeeInfoBuilder.SetName(string name)
        {
            return SetName(name);
        }
    }
}