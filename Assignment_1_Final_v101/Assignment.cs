using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Final_v101
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Submition { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }


        public Assignment(string title, string description, DateTime submition, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            Submition = submition;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public override string ToString()
        {
            return "Assigmment: " + Title + " Description" + Description + " Submition Date: " + Submition + " OralMark " + OralMark + " Total Mark " + TotalMark;
        }
    }
}
