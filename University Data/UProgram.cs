using System;
using Degrees;
using System.Collections.Generic;

namespace UPrograms{
    class UProgram{
        // using list class from system collection generic
        public List<Degree> Degree{get; set;}
        public string Name{get; set;}
        public UProgram(string name, List<Degree> degrees){
            this.Name = name;
            this.Degree = degrees;
        }
    }

    class UProgramAbs{
        // using list class from system collection generic
        public List<DegreeAbs> Degree{get; set;}
        public string Name{get; set;}
        public UProgramAbs(string name, List<DegreeAbs> degrees){
            this.Name = name;
            this.Degree = degrees;
        }
    }
}