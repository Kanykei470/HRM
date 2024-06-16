using HRM.Enums;

namespace HRM.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthYear { get; set; }
        public Gender Gender { get; set; }
        public string Photo { get; set; }//В целях оптимизации, тип строка - хранящая путь к файлу
        public bool IsDeleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
