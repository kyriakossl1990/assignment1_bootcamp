using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Final_v101
{
    class Course
    {
        public enum Stream
        {
            Java,
            CSharp
        }
        public enum Type
        {
            Full,
            Part
        }

        public string Title { get; set; }
        public Stream TheStream { get; set; }
        public Type TheType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }

        public List<Student> StudentsList { get; set; }
        public List<Trainer> TrainerList { get; set; }
        public List<Assignment> AssigmentList { get; set; }


        public Course(string title, Stream theStream, Type theType, DateTime startDate, DateTime stopDate)
        {
            Title = title;
            TheStream = theStream;
            TheType = theType;
            StartDate = startDate;
            StopDate = stopDate;
            StudentsList = new List<Student>();
            TrainerList = new List<Trainer>();
            AssigmentList = new List<Assignment>();

        }
        public override string ToString()
        {
            return "Course : " + Title + " Stream " + TheStream + " Type: " + TheType + " Start Date " + StartDate + " Stop Date " + StopDate;
        }
    }
}
