using System;

namespace Teachers{
    class Teacher{
        public string Name {get; set;}
        public int Age{get; set;}
        private static int instances = 0;
        public Teacher(string name, int age){
            this.Name = name;
            this.Age = age;
            instances++;
        }

        public static int totalTeachers(){
            return instances;
        }
    }
}