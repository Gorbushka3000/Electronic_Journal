using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Teacher
    {
        public Teacher()
        {
            Grades = new HashSet<Grade>();
            Passes = new HashSet<Pass>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Pass> Passes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
