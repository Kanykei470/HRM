﻿namespace HRM.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
