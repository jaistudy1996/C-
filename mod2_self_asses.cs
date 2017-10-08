using System;

namespace University_lab2{
    abstract class Person{
        public string Name {get; set;}
        public int Age{get; set;}
        public Person(string name, int age){
            this.Name = name;
            this.Age = age;
        }

    }

    class TeacherAbs : Person{
        private static int instances = 0;
        public TeacherAbs(string name, int age) : base(name, age){
            instances++;
        }
        public static int totalTeachers(){
            return instances;
        }
    }

    class StudentAbs : Person{
        private static int instances = 0;
        public StudentAbs(string name, int age) : base(name, age){
            instances++;
        }
        public static int totalStudents(){
            return instances;
        }
    }
}