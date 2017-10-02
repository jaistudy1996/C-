
using System;

namespace selfAssesment{
    class studentInfo{
        public static void GetStudentInformation(){
            string firstName;
            string lastName;
            DateTime dob;
            int year, month, date;
            Console.WriteLine("Enter your First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your year, month, day of birth followed by enter: ");
            year = System.Int32.Parse(Console.ReadLine());
            month = System.Int32.Parse(Console.ReadLine());
            date = System.Int32.Parse(Console.ReadLine());
            dob = new DateTime(year, month, date);
            PrintStudentDetails(firstName, lastName, dob);
        }

        public static void PrintStudentDetails(string fName, string lName, DateTime dob){
            Console.WriteLine("{0} {1} was born on {2}", fName, lName, dob);
        }
    }
}