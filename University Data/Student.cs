using System;

namespace Students{
    class Student{
        public string Name{get; set;}
        public int Age{get; set;}
        private static int instances = 0;
        public Student(string name, int age){
            this.Name = name;
            this.Age = age;
            instances++;
        }

        public static int totalStudents(){
            return instances;
        }
    }
}