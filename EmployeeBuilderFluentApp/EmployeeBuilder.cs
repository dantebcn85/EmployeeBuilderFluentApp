namespace EmployeeBuilderFluentApp
{
    public abstract class EmployeeBuilder : IEmployeeBuilder
    {
        protected Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public Employee Build() => employee;
    }
}
