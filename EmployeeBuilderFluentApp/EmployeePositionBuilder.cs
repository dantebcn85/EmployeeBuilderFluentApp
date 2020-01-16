namespace EmployeeBuilderFluentApp
{
    public class EmployeePositionBuilder<T> : EmployeeSalaryBuilder<EmployeePositionBuilder<T>>, IEmployeePositionBuilder where T : EmployeePositionBuilder<T>
    {
        public T AtPosition(string position)
        {
            employee.Position = position;
            return (T)this;
        }

        IEmployeeSalaryBuilder IEmployeePositionBuilder.AtPosition(string position)
        {
            return this.AtPosition(position);
        }
    }
}
