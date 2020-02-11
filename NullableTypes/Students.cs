using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    public class Students {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? SAT { get; set; }
        public string GPA { get; set; }
        public Major? Major { get; set; }
        //public int? MajorID { get; set; }



        public Students(int id, string name, int? sat, string gpa, Major? major) {
            this.ID = id;
            this.Name = name;
            this.SAT = sat;
            this.GPA = gpa;
            Major = major;
    
        }

        public void Print() {
            Console.WriteLine($"{this.ID}. {this.Name} has an SAT score of {this.SAT} and a GPA of {this.GPA}. {this.Name} will be majoring in {((Major != null) ? Major. Description : "Undeclared")}.");
        }

    }

}
