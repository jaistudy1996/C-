using System;
using selfAssesment;
using class_1;
using Courses;
using Degrees;
using Students;
using Teachers;
using UPrograms;
using System.Collections;

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
            ArrayList studArr = new ArrayList(); 
            studArr.Add(student1);
            studArr.Add(student2);
            studArr.Add(student3);
            ArrayList teachArr = new ArrayList();
            teachArr.Add(teacher1);
            Course course1 = new Course(name:"Programming with C#", students:studArr, teachers:teachArr);
            Console.WriteLine((Student)course1.students[1]);
            Console.WriteLine((Teacher)course1.teachers[0]);
        }
    }
}
