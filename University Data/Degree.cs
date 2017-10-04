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
}