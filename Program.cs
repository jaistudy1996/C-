using System;
using selfAssesment;

namespace intro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            Console.Write("Enter first Number: ");
            firstNumber = System.Double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = System.Double.Parse(Console.ReadLine());
            double result;
            try{
                result = Divide(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch(DivideByZeroException){
                Console.WriteLine("Enter a valid denominator. ");
            }
            catch(Exception){
                Console.WriteLine("Unexpected Error occured!");
            }
            studentInfo.GetStudentInformation();
        }

        static double Divide(double firstNumber, double secondNumber){
            if(secondNumber == 0){
                throw new System.DivideByZeroException();
            }
            return firstNumber/secondNumber;
        }
    }
}
