using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class ClassNumber
    {
        public ClassNumber()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int ClassNum { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
