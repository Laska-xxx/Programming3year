namespace StartWithLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*---------Task 1--------------------------------*/
            
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Vasya", 25, 80000),
                new Employee(2, "Sasha", 31, 55000),
                new Employee (3, "Danya", 28, 67000),
                new Employee (4, "Maya", 35, 71000)
            };

            var conditionEmployees = employees.Where(e => e.Age > 30 && e.Salary > 60000)
                .Select(e => new { e.Name, e.Salary });

            foreach (var item in conditionEmployees)
            {
                Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary} (Task 1)");
            }

            /*---------Task 2--------------------------------*/

            var averageLargestSalaries = employees.OrderByDescending(e => e.Salary)
                .Take(3)
                .Average(e => e.Salary);

            Console.WriteLine($"Average first 3 salaries: {averageLargestSalaries:F2} (Task 2)");

            /*---------Task 3--------------------------------*/

            List<DepartmentEmployee> departmentEmployee = new List<DepartmentEmployee>
            {
                new DepartmentEmployee(10, "Vasya", 25, 80000, "IT"),
                new DepartmentEmployee(11, "Sasha", 31, 55000, "HR"),
                new DepartmentEmployee (12, "Danya", 28, 67000, "IT"),
            };

            var groupEmployee = departmentEmployee.GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, MaxSalary = g.Max(e => e.Salary) });

            foreach (var item in groupEmployee)
            {
                Console.WriteLine($"Department: {item.Department}, Max salary: {item.MaxSalary} (Task 3)");
            }

            /*---------Task 4--------------------------------*/

            List<Project> projects = new List<Project>
            {
                new Project(01, "Safty call", 1),
                new Project(02, "Scam call", 2),
                new Project(03, "Magical Abys", 3)
            };

            var unitedProjects = from project in projects
                                 join employee in employees on project.ManagerId equals employee.Id
                                 select new { ManagerName = employee.Name, ProjectName = project.Name };

            foreach (var item in unitedProjects)
            {
                Console.WriteLine($"Manager name: {item.ManagerName}, Project name: {item.ProjectName} (Task 4)");
            }

            /*---------Task 5--------------------------------*/

            var employeesWith70k = employees.FirstOrDefault(e => e.Salary == 70000);

            if (employeesWith70k != null)
            {
                Console.WriteLine($"Employee with 70k salary: {employeesWith70k.Name} (Task 5)");
            }
            else
            {
                Console.WriteLine("Не найден (Task 5)");
            }
        }
    }
}