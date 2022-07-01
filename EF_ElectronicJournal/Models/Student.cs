using EF_ElectronicJournal.Models;
using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Student : User
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            Passes = new HashSet<Pass>();
        }
        public int ClassNumberId { get; set; }
        public int TeacherId { get; set; }

        public virtual ClassNumber ClassNumber { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Pass> Passes { get; set; }
    }
}
