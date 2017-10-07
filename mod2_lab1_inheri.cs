using System;

namespace EmployeeTut{
    public class Employee{
        private string name;
        private double baseSalary;
        private int empID;
        private static int idcounter;
        public Employee(string name, double baseSalary){
            this.name = name;
            this.baseSalary = baseSalary;
            idcounter++;
            this.empID = idcounter;
        }
        public double getSalary(){
            return this.baseSalary;
        }
        public string getName(){
            return this.name;
        }
        public int getEmployeeID(){
            return this.empID;
        }
        public string toString(){
            return $"{this.getEmployeeID()} {this.getName()}";
        }
        public virtual string employeeStatus(){
            return toString() + "is in company system";
        }
    }

    public class TechnicalEmployee : Employee{
        public int successfulCheckins = 5;
        public TechnicalEmployee(string name) : base(name, 75000){
        }
        public override string employeeStatus(){
            return $"{this.toString()} has {this.successfulCheckins} successful checkins." ;
        }
    }

    public class BussinessEmployee : Employee{
        public double bonusBudget = 1000;
        public BussinessEmployee(string name) : base(name, 50000){
        }
        public override string employeeStatus(){
            return $"{this.toString()} with a bonus budget of {this.bonusBudget}";
        }
    }
}