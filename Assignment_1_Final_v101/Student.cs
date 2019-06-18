using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Final_v101
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double TuitionFee { get; set; }
        public List<Assignment> StudentAssigmentsList { get; set; }

        public Student()
        {

            
        }

        public Student(string firstName, string lastName, DateTime birthDate, double tuitionFee)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            TuitionFee = tuitionFee;
            StudentAssigmentsList = new List<Assignment>();
        }
        public override string ToString()
        {
            return "Students: " + FirstName + " " + LastName + " BrithDate: " + BirthDate + " tuition fee: " + TuitionFee;
        }
    }
}
