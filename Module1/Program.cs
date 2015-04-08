using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module1
{
    class Program
    {
        private enum Degree
        {
            Bachelor,
            Master
        }

        static void Main(string[] args)
        {
            // student information
            string studentFirstName, studentLastName, studentAddressLine1, studentAddressLine2, studentCity, studentState, studentCountry = string.Empty;
            DateTime studentBirthDate;
            int studentZipCode;
            
            // proffesor information
            string proffesorFirstName, professorLastName, professorAddressLine1, professorAddressLine2, professorCity, professorState, professorCountry = string.Empty;
            DateTime professorBirthDate;
            int professorZipCode;

            // university degree
            Degree universityDegree = Degree.Bachelor;
            int requiredCredits = 10;

            // university programm
            string programName = string.Empty;
            string departmentHeade = string.Empty;

            // course information
            string courseName = string.Empty;
            string proffesorName = string.Empty;

            // fill some data
            studentBirthDate = DateTime.Now;
            studentFirstName = "Petro";
            studentLastName = "Petrov";
            studentZipCode = 568;

            // output values to console
            Console.WriteLine("Student - {0} {1}, birthdate - {2}", studentFirstName, studentLastName, studentBirthDate);
            Console.WriteLine("Student zip code - {0}", studentZipCode);

            // wait for user input
            Console.ReadKey();
        }
    }
}
