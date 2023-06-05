using System;

namespace T5L27PracaDomowa
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EmploymentDate { get; set; } = DateTime.Now;
        public bool IsFired { get; set; } = false;
        public DateTime? DismissalDate { get; set; }
        public int? Salary { get; set; }
    }
}
