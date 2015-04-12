using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        private enum Degree
        {
            Bachelor,
            Master
        }

        private struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public int ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }

        private struct Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public int ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }            
        }

        private struct UniversityProgram
        {
            public string Name { get; set; }
            public Degree Degree { get; set; }
            public int RequiredCredits { get; set; }
        }

        private struct Course
        {
            public string Name { get; set; }
            public Teacher Teacher { get; set; }
        }

        static void Main(string[] args)
        {
            const int studentsCount = 5;
            Student[] students = new Student[studentsCount];
            // fill students array 
            for (int studIndex = 0; studIndex < students.Length; studIndex++)
            {
                students[studIndex].FirstName = "Petr";
                students[studIndex].LastName = "Petrov";
                students[studIndex].AddressLine1 = string.Format("address 1 for student {0}", studIndex);
                students[studIndex].AddressLine2 = string.Format("address 2 for student {0}", studIndex);
                students[studIndex].City = string.Format("city for student {0}", studIndex);
                students[studIndex].Country = string.Format("country for student {0}", studIndex);
                students[studIndex].ZipCode = studIndex;
                students[studIndex].BirthDate = DateTime.Now;
            }

            // write to console info about students
            for (int studIndex = 0; studIndex < students.Length; studIndex++)
            {
                Console.WriteLine("STUDENT INFO");
                Console.WriteLine("Name: {0} {1}", students[studIndex].FirstName, students[studIndex].LastName);
                Console.WriteLine("BirthDate: {0}", students[studIndex].BirthDate);
                Console.WriteLine("Address: {0} {1}", students[studIndex].AddressLine1, students[studIndex].AddressLine2);
                Console.WriteLine("ZipCode: {0}", students[studIndex].ZipCode);
                Console.WriteLine("City {0} in {1}", students[studIndex].City, students[studIndex].Country);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
