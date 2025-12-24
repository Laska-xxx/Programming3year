namespace StartWithLinQ
{
    internal class Project
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int ManagerId { get; private set; }

        public Project(int id, string name, int managerId)
        {
            Id = id;
            Name = name;
            ManagerId = managerId;
        }
    }
}