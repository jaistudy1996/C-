using System;
using selfAssesment;
using class_1;
using Courses;
using Degrees;
using Students;
using Teachers;
using UPrograms;
using EmployeeTut;
using EmployeeTutAbs;
using University_lab2;
using System.Collections.Generic;

namespace intro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // double firstNumber = 0;
            // double secondNumber = 0;
            // Console.Write("Enter first Number: ");
            // firstNumber = System.Double.Parse(Console.ReadLine());
            // Console.Write("Enter second number: ");
            // secondNumber = System.Double.Parse(Console.ReadLine());
            // double result;
            // try{
            //     result = Divide(firstNumber, secondNumber);
            //     Console.WriteLine(result);
            // }
            // catch(DivideByZeroException){
            //     Console.WriteLine("Enter a valid denominator. ");
            // }
            // catch(Exception){
            //     Console.WriteLine("Unexpected Error occured!");
            // }
            // studentInfo.GetStudentInformation();

            //CarTest();
            uniApp();
            emplTest();
            uniAppAbs();
        }

        static double Divide(double firstNumber, double secondNumber){
            if(secondNumber == 0){
                throw new System.DivideByZeroException();
            }
            return firstNumber/secondNumber;
        }

        static void CarTest(){
            Car car1 = new Car("Red", 2008);
            int totalCars = Car.CountCars();
            Console.WriteLine($"There are a total of {totalCars} in inventory");
        }

        static void uniApp(){
            Student student1 = new Student(name:"student1", age:1);
            Student student2 = new Student(name: "student2", age:2);
            Student student3 = new Student(name: "student3", age:3);
            Console.WriteLine($"Total students: {Student.totalStudents()}");
            Teacher teacher1 = new Teacher("teacher1", 1);
            // ArrayList studArr = new ArrayList(); 
            List<Student> studArr = new List<Student>();
            studArr.Add(student1);
            studArr.Add(student2);
            studArr.Add(student3);
            List<Teacher> teachArr = new List<Teacher>();
            teachArr.Add(teacher1);
            Course course1 = new Course(name:"Programming with C#", students:studArr, teachers:teachArr);
            List<Course> courseArr = new List<Course>();
            courseArr.Add(course1);
            Degree degree1 = new Degree(name:"Bachelor's", courses: courseArr);
            List<Degree> degreeArr = new List<Degree>();
            degreeArr.Add(degree1);
            UProgram uprog = new UProgram(name: "Information Technology", degrees: degreeArr);
            // Console statements;
            Console.WriteLine($"Name of the program: {uprog.Name}");
            Console.WriteLine($"Name of Degree in program is: {uprog.Degree[0].Name}");
            Console.WriteLine($"Name of course in degree is: {uprog.Degree[0].Courses[0].CourseName}");
            Console.WriteLine($"Number of students in this course is: {uprog.Degree[0].Courses[0].students.Count}");
        }

        static void emplTest(){
            var employee1 = new Employee("Libby", 2000);
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BussinessEmployee("Winter");

            var employee1abs = new TechnicalEmployeeAbs("Libby");
            var employee2abs = new TechnicalEmployeeAbs("Zaynah");
            var employee3abs = new BussinessEmployeeAbs("Winter");

            Console.WriteLine($"{employee1.employeeStatus()} ... {employee2.employeeStatus()} ... {employee3.employeeStatus()}");

            Console.WriteLine($"{employee1abs.employeeStatus()} ... {employee2abs.employeeStatus()} ... {employee3abs.employeeStatus()}");
        }

        static void uniAppAbs(){
            StudentAbs student1 = new StudentAbs(name:"student1", age:1);
            StudentAbs student2 = new StudentAbs(name: "student2", age:2);
            StudentAbs student3 = new StudentAbs(name: "student3", age:3);
            Console.WriteLine($"Total students: {Student.totalStudents()}");
            TeacherAbs teacher1 = new TeacherAbs("teacher1", 1);
            // ArrayList studArr = new ArrayList(); 
            List<StudentAbs> studArr = new List<StudentAbs>();
            studArr.Add(student1);
            studArr.Add(student2);
            studArr.Add(student3);
            List<TeacherAbs> teachArr = new List<TeacherAbs>();
            teachArr.Add(teacher1);
            CourseAbs course1 = new CourseAbs(name:"Programming with C#", students:studArr, teachers:teachArr);
            List<CourseAbs> courseArr = new List<CourseAbs>();
            courseArr.Add(course1);
            DegreeAbs degree1 = new DegreeAbs(name:"Bachelor's", courses: courseArr);
            List<DegreeAbs> degreeArr = new List<DegreeAbs>();
            degreeArr.Add(degree1);
            UProgramAbs uprog = new UProgramAbs(name: "Information Technology", degrees: degreeArr);
            // Console statements;
            Console.WriteLine($"Name of the program: {uprog.Name}");
            Console.WriteLine($"Name of Degree in program is: {uprog.Degree[0].Name}");
            Console.WriteLine($"Name of course in degree is: {uprog.Degree[0].Courses[0].CourseName}");
            Console.WriteLine($"Number of students in this course is: {uprog.Degree[0].Courses[0].students.Count}");

            // child still stays a child no matter what
            StudentAbs mystud =  new StudentAbs("test", 2);
            Person myp = mystud;
            Console.WriteLine($"{mystud.GetType()}");
            Console.WriteLine($"{myp.GetType()}");
        }
    }
}
