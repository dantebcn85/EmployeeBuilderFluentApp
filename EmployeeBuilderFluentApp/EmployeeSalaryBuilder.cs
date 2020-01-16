namespace EmployeeBuilderFluentApp
{
    public class EmployeeSalaryBuilder<T> : EmployeeBuilder, IEmployeeSalaryBuilder where T : EmployeeSalaryBuilder<T>
    {
        public T WithSalary(double salary)
        {
            employee.Salary = salary;
            return (T)this;
        }

        IEmployeeBuilder IEmployeeSalaryBuilder.WithSalary(double salary)
        {
            return this.WithSalary(salary);
        }
    }
}
