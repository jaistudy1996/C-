using System;
using Teachers;
using Students;
using University_lab2;
using System.Collections.Generic;

namespace Courses{
    class Course{
        public List<Student> students{get; set;}
        public List<Teacher> teachers{get; set;}
        public string CourseName{get; set;}
        public static int instances = 0;
        public Course(string name, List<Student> students, List<Teacher> teachers){
            this.CourseName = name;
            this.students = students;
            this.teachers = teachers;
            instances++;
        }

        public int totalCouses(){
            return instances;
        }
    }

    class CourseAbs{
        public List<StudentAbs> students{get; set;}
        public List<TeacherAbs> teachers{get; set;}
        public string CourseName{get; set;}
        public static int instances = 0;
        public CourseAbs(string name, List<StudentAbs> students, List<TeacherAbs> teachers){
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