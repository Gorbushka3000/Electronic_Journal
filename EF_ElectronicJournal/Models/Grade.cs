using EF_ElectronicJournal.Models;
using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Grade : Ratings
    {
        public int grade;
        public string? comment;
        public int Id { get; set; }
        public int Grades
        {
            get { return grade; }
            set
            {
                grade = value;
                OnPropertyChanged("Grades");
            }
        }
        public string? Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                OnPropertyChanged("Comment");
            }
        }

    }
}
