using System;
using Courses;
using System.Collections.Generic;

namespace Degrees{
    class Degree{
        public Course course{get; set;}
        public string Name{get; set;}
        public List<Course> Courses{get; set;}
        
        public Degree(string name, List<Course> courses){
            this.Name = name;
            this.Courses = courses;
        }
    }

    class DegreeAbs{
        public Course course{get; set;}
        public string Name{get; set;}
        public List<CourseAbs> Courses{get; set;}
        
        public DegreeAbs(string name, List<CourseAbs> courses){
            this.Name = name;
            this.Courses = courses;
        }
    }
}