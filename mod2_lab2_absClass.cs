using System;

namespace EmployeeTutAbs{
    abstract class EmployeeAbs{
        private string name;
        private double baseSalary;
        private int empID;
        private static int idcounter;
        public EmployeeAbs(string name, double baseSalary){
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
        public abstract string employeeStatus();
    }

    class TechnicalEmployeeAbs : EmployeeAbs{
        public int successfulCheckins = 5;
        public TechnicalEmployeeAbs(string name) : base(name, 75000){
        }
        public override string employeeStatus(){
            return $"{this.toString()} has {this.successfulCheckins} successful checkins." ;
        }
    }

    class BussinessEmployeeAbs : EmployeeAbs{
        public double bonusBudget = 1000;
        public BussinessEmployeeAbs(string name) : base(name, 50000){
        }
        public override string employeeStatus(){
            return $"{this.toString()} with a bonus budget of {this.bonusBudget}";
        }
    }
}