namespace StartWithLinQ
{
    internal class DepartmentEmployee : Employee
    {
        public string Department {  get; private set; }
        public DepartmentEmployee(int id, string name, int age, int salary, string department) : base(id, name, age, salary)
        {
            Department = department;
        }
    }

}