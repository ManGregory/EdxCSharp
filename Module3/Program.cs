using System;

namespace Module3
{
    class Program
    {
        private static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's second name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's address line 1");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address line 2");
            string addressLine2 = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, addressLine1, addressLine2);
        }

        private static void PrintStudentDetails(string firstName, string lastName, string addressLine1, string addressLine2)
        {
            Console.WriteLine("STUDENT INFO");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Addresses: {0}, {1}", addressLine1, addressLine2);
            Console.WriteLine();
        }

        private static void GetProfessorInfo()
        {
            Console.WriteLine("Enter the professor's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the professor's second name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the professor's address line 1");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the professor's address line 2");
            string addressLine2 = Console.ReadLine();
            PrintProfessorDetails(firstName, lastName, addressLine1, addressLine2);
        }

        private static void PrintProfessorDetails(string firstName, string lastName, string addressLine1, string addressLine2)
        {
            Console.WriteLine("PROFESSOR INFO");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Addresses: {0}, {1}", addressLine1, addressLine2);
            Console.WriteLine();
        }

        private static void GetCourseInfo()
        {
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            PrintCourseDetails(courseName);
        }

        private static void PrintCourseDetails(string courseName)
        {
            Console.WriteLine("Course: {0}", courseName);
        }

        private static void ValidateStudentBirthdate()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            GetStudentInfo();
            GetProfessorInfo();
            GetCourseInfo();
            Console.ReadLine();
            ValidateStudentBirthdate();
            Console.ReadLine();
        }
    }
}
