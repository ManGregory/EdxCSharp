using System;

namespace Module6
{
    internal class Person
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

    class Student : Person
    {
        private static int _count;

        public Student()
        {
            _count++;
        }

        public static int Count
        {
            get { return _count; }
        }

        public void TakeTest()
        {
            throw new NotImplementedException();
        }
    }

    class Teacher : Person
    {
        public int GradeTest()
        {
            throw new NotImplementedException();
        }
    }

    class Degree
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

    class Course
    {
        private string _name;
        private Student[] _students;
        private Object[] _teachers;
        private const int StudentsDefaultSize = 3;
        private const int TeachersDefaultSize = 3;

        public Course()
        {
            _students = new Student[StudentsDefaultSize];
            _teachers = new Teacher[TeachersDefaultSize];
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Object[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }
    }

    class UProgram
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

    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new Student {FirstName = "Petr"},
                new Student {FirstName = "Ivan"},
                new Student {FirstName = "Igor"}
            };
            var course = new Course { Name = "Programming with C#", Students = students };
            var teacher = new Teacher { FirstName = "Nikiphor" };
            course.Teachers[0] = teacher;
            var degree = new Degree { Name = "Bachelor", Course = course };
            var program = new UProgram { Name = "Information Technology", Degree = degree };

            Console.WriteLine("The {0} program contains the {1} of Science degree", program.Name, program.Degree.Name);
            Console.WriteLine("The {0} of Science degree contains the course {1}", degree.Name, degree.Course.Name);
            Console.WriteLine("The {0} course contains {1} students", course.Name, course.Students.Length);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
