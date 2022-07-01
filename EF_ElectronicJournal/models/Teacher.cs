using EF_ElectronicJournal.Models;
using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Teacher : User
    {
        public Teacher()
        {
            Grades = new HashSet<Grade>();
            Passes = new HashSet<Pass>();
            Students = new HashSet<Student>();
        }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Pass> Passes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
