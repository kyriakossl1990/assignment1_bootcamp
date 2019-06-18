using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Final_v101
{
    class Program
    {
        public enum inputMenu
        {
            
            StudentManual=1,
            PrintStudent,
            PrintTrainers,
            PrintAssigments,
            PrintCourse,
            PrintTrainerPerCourse,
            PrintStudentPerCourse,
            PrintAssignmentsPerCourse,
            PrintAssignmentsPerStudent,
            PrintStudentWithMoreClass,
            AssigmnetSubmissions
        }

        static void Main(string[] args)
        {

            // List of All
            List<Student> studentsList = new List<Student>();
            List<Trainer> trainersList = new List<Trainer>();
            List<Assignment> assignmentList = new List<Assignment>();
            List<Course> courseList = new List<Course>();
            List<Student> studentsMoreThanOneCourses = new List<Student>();

            // Object Greation from Contsraction
            Course course1 = new Course("mathima1", Course.Stream.CSharp, Course.Type.Full, new DateTime(2019, 01, 15), new DateTime(2019, 06, 15));
            Course course2 = new Course("mathima2", Course.Stream.Java, Course.Type.Full, new DateTime(2019, 01, 15), new DateTime(2019, 06, 15));
            Course course3 = new Course("mathima3", Course.Stream.CSharp, Course.Type.Full, new DateTime(2019, 01, 15), new DateTime(2019, 06, 15));
            Course course4 = new Course("mathima4", Course.Stream.Java, Course.Type.Full, new DateTime(2019, 01, 15), new DateTime(2019, 06, 15));

            Student student1 = new Student("Nikos", "Nikou", new DateTime(1990, 01, 10), 500);
            Student student2 = new Student("Gianis", "Giannou", new DateTime(1990, 01, 10), 700);
            Student student3 = new Student("Baggelis", "Euaggelou", new DateTime(1990, 01, 10), 500);
            Student student4 = new Student("gianis", "giannou", new DateTime(1990, 01, 10), 700);

            Trainer trainer1 = new Trainer("Gianiis", "Giannakis", "Mathima 1");
            Trainer trainer2 = new Trainer("Dimitiris", "Dimitriou", "Mathima 2");
            Trainer trainer3 = new Trainer("Kyriakos", "Kyriakoy", "Mathima 1");
            Trainer trainer4 = new Trainer("Aggelos", "Aggelou", "Mathima 1");

            Assignment Assignment1 = new Assignment("ass 1", "Bla bla bla", new DateTime(2019, 03, 6), 7, 9);
            Assignment Assignment2 = new Assignment("ass 2", "Bla bla bla", new DateTime(2019, 03, 9), 7, 9);
            Assignment Assignment3 = new Assignment("ass 3", "Bla bla bla", new DateTime(2019, 03, 1), 7, 9);
            Assignment Assignment4 = new Assignment("ass 4", "Bla bla bla", new DateTime(2019, 03, 22), 7, 9);


            // Add all to all list
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);
            courseList.Add(course4);

            studentsList.Add(student1);
            studentsList.Add(student2);
            studentsList.Add(student3);
            studentsList.Add(student4);

            trainersList.Add(trainer1);
            trainersList.Add(trainer2);
            trainersList.Add(trainer3);
            trainersList.Add(trainer4);

            assignmentList.Add(Assignment1);
            assignmentList.Add(Assignment2);
            assignmentList.Add(Assignment3);
            assignmentList.Add(Assignment4);

            // Add trainer to course
            course1.TrainerList.Add(trainer1);
            course2.TrainerList.Add(trainer2);
            course3.TrainerList.Add(trainer3);
            course4.TrainerList.Add(trainer4);
            course4.TrainerList.Add(trainer3);
            course2.TrainerList.Add(trainer1);


            // Add course to student
            course1.StudentsList.Add(student1);
            course2.StudentsList.Add(student2);
            course3.StudentsList.Add(student3);
            course4.StudentsList.Add(student4);
            course4.StudentsList.Add(student1);
            course4.StudentsList.Add(student2);
            course4.StudentsList.Add(student3);

            // Add Assignment to course
            course1.AssigmentList.Add(Assignment1);
            course1.AssigmentList.Add(Assignment3);
            course1.AssigmentList.Add(Assignment2);
            course2.AssigmentList.Add(Assignment2);
            course3.AssigmentList.Add(Assignment3);
            course4.AssigmentList.Add(Assignment4);

            // Add Assignment to student
            student1.StudentAssigmentsList.Add(Assignment1);
            student2.StudentAssigmentsList.Add(Assignment2);
            student3.StudentAssigmentsList.Add(Assignment3);
            student4.StudentAssigmentsList.Add(Assignment4);


            bool menuInput = false;
            do
            {
                Console.WriteLine("Choose one of the below numbers to navigate through the menu.\n");

                //  Menu array & loop
                string[] menuOptions = {"Add a new student manually.","Print all the students.","Print all the trainers .","Print all the assignments .","Print all the courses.",
                "Print all the trainers per course.","Print all the students per course.", "Print all the assignments per course.","Print all the assignments per student.",
                "Print a list of students that belong to more than one courses.", "Enter assigmnet submissions as Year/month/date."};

                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {menuOptions[i]}");
                }
                Console.Write("\n\nType your number selection: ");

                int corrInput;
                bool userInput;
                while (!(userInput = int.TryParse(Console.ReadLine(), out corrInput)))
                {
                    Console.WriteLine($"Invalid value. Enter 1 to 11 for menu!");
                    Console.Write("\nType your number selection: ");
                }

                inputMenu menu = (inputMenu)corrInput;
                switch (menu)
                {
                    case inputMenu.StudentManual:
                        Console.WriteLine("Enter student name : ");
                        string inputFirstName = Console.ReadLine();

                        Console.WriteLine("Enter student last name ");
                        string inputLastName = Console.ReadLine();

                        Console.WriteLine("Enter student birthdate Year/month/date");
                        var inputBirthDate = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter student tuition ");
                        double inputTuitionFee = double.Parse(Console.ReadLine());

                        Student student = new Student() // constructor for input student
                        {
                            FirstName = inputFirstName,
                            LastName = inputLastName,
                            BirthDate = inputBirthDate,
                            TuitionFee = inputTuitionFee,
                            StudentAssigmentsList = new List<Assignment>()
                        };

                        studentsList.Add(student);
                        break;

                    case inputMenu.PrintStudent: ///Print all the students 
                        foreach (Student students in studentsList)
                        {
                            Console.WriteLine(students);
                        }
                        break;

                    case inputMenu.PrintTrainers: //Print all the trainers

                        foreach (Trainer trainers in trainersList)
                        {
                            Console.WriteLine(trainers);
                        }
                        break;

                    case inputMenu.PrintAssigments: // Print all the assignments 
                        foreach (Assignment Assignment in assignmentList)
                        {
                            Console.WriteLine(Assignment);
                        }
                        break;

                    case inputMenu.PrintCourse: // Print all the courses
                        foreach (Course course in courseList)
                        {
                            Console.WriteLine(course);
                        }
                        break;

                    case inputMenu.PrintTrainerPerCourse:// Print all the trainers per course
                        foreach (Course courses in courseList)
                        {
                            foreach (Trainer trainers in trainersList)
                            {
                                Console.WriteLine($"{trainers.FirstName} {trainers.LastName} at cource {courses.Title}");
                            }
                        }
                        break;

                    case inputMenu.PrintStudentPerCourse: //Print all the students per course
                        foreach (Course students in courseList)
                        {
                            foreach (Student item in studentsList)
                            {
                                Console.WriteLine($"{students.Title} has the  {item.LastName} {item.FirstName}.") ;
                            }
                        }
                        break;

                    case inputMenu.PrintAssignmentsPerCourse: //Print all the assignments per course
                        foreach (Course courses in courseList)
                        {
                            foreach (Assignment assignments in assignmentList)
                            {
                                Console.WriteLine($" For cource {courses.Title} the assignment is {assignments.Title} ");
                            }
                        }
                        break;

                    case inputMenu.PrintAssignmentsPerStudent: //Print all the assignments per student
                        foreach (Student students in studentsList)
                        {
                            foreach (Assignment assignments in assignmentList)
                            {
                                Console.WriteLine($"For student: {students.FirstName} {students.LastName} the assignment is: {assignments.Title}");
                            }
                        }

                        break;
                    

                    case inputMenu.PrintStudentWithMoreClass: //Print a list of students that belong to more than one courses

                        foreach (Course courses in courseList)
                        {
                            if (courses.StudentsList.Count > 1)
                            {
                                foreach (Student item in studentsList)
                                {
                                    Console.WriteLine($"{item.FirstName} {item.LastName} has mote than one course");
                                }
                            }
                        }
                        break;


                    case inputMenu.AssigmnetSubmissions: 
                        Console.WriteLine("Enter Assigmnent submition date");
                        DateTime inputDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine(inputDate);

                        if (inputDate.DayOfWeek == DayOfWeek.Sunday || inputDate.DayOfWeek == DayOfWeek.Saturday )
                        {
                            Console.WriteLine("Its Sunday OR Saturday");
                        }
                        else
                        {
                        
                        }
                        break;

                    //Enter assigmnet submissions as Year / month / date

                    default:
                        Console.Write("\nInvalid Input. Try to enter 1 to 11 for menu.");
                        break;

                }

            } while (menuInput == false);


        }
    }
}
