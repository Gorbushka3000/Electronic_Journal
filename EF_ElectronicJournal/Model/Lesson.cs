using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Lesson
    {
        public Lesson()
        {
            Grades = new HashSet<Grade>();
            Passes = new HashSet<Pass>();
        }

        public int Id { get; set; }
        public string? LessonName { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Pass> Passes { get; set; }
    }
}
