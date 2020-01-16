using System;

namespace EmployeeBuilderFluentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = EmployeeBuilderDirector
                .NewEmployee
                .SetName("Peter")
                .AtPosition("Software Developer")
                .WithSalary(1000)
                .Build();


            Console.WriteLine(emp);
        }
    }
}
