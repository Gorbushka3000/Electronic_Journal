using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            Passes = new HashSet<Pass>();
        }

        public int Id { get; set; }
        public int ClassNumberId { get; set; }
        public int TeacherId { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ClassNumber ClassNumber { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Pass> Passes { get; set; }
    }
}
