using System;
using Teachers;
using Students;
using System.Collections;

namespace Courses{
    class Course{
        public ArrayList students{get; set;}
        public ArrayList teachers{get; set;}
        public string CourseName{get; set;}
        public static int instances = 0;
        public Course(string name, ArrayList students, ArrayList teachers){
            this.CourseName = name;
            this.students = students;
            this.teachers = teachers;
            instances++;
        }

        public int totalCouses(){
            return instances;
        }
    }
}