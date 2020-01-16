namespace EmployeeBuilderFluentApp
{
    public class EmployeeBuilderDirector : EmployeeInfoBuilder <EmployeeBuilderDirector>
    {
        public static IEmployeeInfoBuilder NewEmployee => new EmployeeBuilderDirector();
    }
}
