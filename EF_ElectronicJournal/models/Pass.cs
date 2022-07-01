using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Pass
    {
        public int Id { get; set; }
        public string Pass1 { get; set; } = null!;
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }
        public DateTime DateRating { get; set; }
        public int LessonId { get; set; }

        public virtual Lesson Lesson { get; set; } = null!;
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
