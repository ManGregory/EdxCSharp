using System.Collections;

namespace Module7
{
    using System;

    internal class Student
    {
        private static int _count;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private string _country;
        private int _zipCode;
        private Stack _grades;

        public Student()
        {
            _count++;
            _grades = new Stack();
        }

        public static int Count
        {
            get { return _count; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public Stack Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }
    }

    internal class Teacher
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private string _country;
        private int _zipCode;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
    }

    internal class Degree
    {
        private string _name;
        private Course _course;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Course Course
        {
            get { return _course; }
            set { _course = value; }
        }
    }

    internal class Course
    {
        private string _name;
        private ArrayList _students;
        private Teacher[] _teachers;
        private const int StudentsDefaultSize = 3;
        private const int TeachersDefaultSize = 3;

        public Course()
        {
            _students = new ArrayList(StudentsDefaultSize);
            _teachers = new Teacher[TeachersDefaultSize];
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public ArrayList Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Teacher[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }
    }

    internal class UProgram
    {
        private string _name;
        private int _requiredCredits;
        private Degree _degree;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RequiredCredits
        {
            get { return _requiredCredits; }
            set { _requiredCredits = value; }
        }

        public Degree Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new ArrayList();
            students.AddRange(CreateStudents());

            var course = new Course {Name = "Programming with C#", Students = students};
            var teacher = new Teacher {FirstName = "Nikiphor"};
            course.Teachers[0] = teacher;
            var degree = new Degree {Name = "Bachelor", Course = course};
            var program = new UProgram {Name = "Information Technology", Degree = degree};

            // print the information about students
            ListStudents(students);

            // output from module 6
            Console.WriteLine("The {0} program contains the {1} of Science degree", program.Name, program.Degree.Name);
            Console.WriteLine("The {0} of Science degree contains the course {1}", degree.Name, degree.Course.Name);
            Console.WriteLine("The {0} course contains {1} students", course.Name, course.Students.Count);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void ListStudents(ArrayList students)
        {
            Console.WriteLine("The list of students:");
            foreach (var studentObject in students)
            {
                // check the object type, because ArrayList contains array of objects and we can store anything
                var student = studentObject as Student;
                if (student != null)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }
            }
            Console.WriteLine();
        }

        private static Student[] CreateStudents()
        {
            var student1 = new Student {FirstName = "John", LastName = "Petrov"};
            var student2 = new Student {FirstName = "Dave", LastName = "Laru"};
            var student3 = new Student {FirstName = "Frodo", LastName = "Beggins"};
            AddGradesToStudent(student1);
            AddGradesToStudent(student2);
            AddGradesToStudent(student3);
            return new[] {student1, student2, student3};
        }

        private static void AddGradesToStudent(Student student)
        {
            student.Grades.Push(1);
            student.Grades.Push(2);
            student.Grades.Push(3);
            student.Grades.Push(4);
            student.Grades.Push(5);
        }
    }
}

