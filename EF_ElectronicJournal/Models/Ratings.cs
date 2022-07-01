using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EF_ElectronicJournal.Models
{
    public class Ratings : INotifyPropertyChanged
    {
        public int studentId;
        public int teacherId;
        public DateTime dateRating;
        public int lessonId;
        public Lesson? lesson;
        public Student? student;
        public Teacher? teacher;
        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId");
            }
        }
        public int TeacherId
        {
            get { return teacherId; }
            set
            {
                teacherId = value;
                OnPropertyChanged("TeacherId");
            }
        }
        public DateTime DateRating
        {
            get { return dateRating; }
            set
            {
                dateRating = value;
                OnPropertyChanged("DateRating");
            }
        }
        public int LessonId
        {
            get { return lessonId; }
            set
            {
                lessonId = value;
                OnPropertyChanged("LessonId");
            }
        }
        public virtual Lesson? Lesson
        {
            get { return lesson; }
            set
            {
                lesson = value;
                OnPropertyChanged("Lesson");
            }
        }
        public virtual Student? Student
        {
            get { return student; }
            set
            {
                student = value;
                OnPropertyChanged("Student");
            }
        }
        public virtual Teacher? Teacher
        {
            get { return teacher; }
            set
            {
                teacher = value;
                OnPropertyChanged("Teacher");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
