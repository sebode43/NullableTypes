using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Students {
        public int ID;
        public string Name;
        public int? SAT;
        public string GPA;



        public Students(int id, string name, int? sat, string gpa) {
            this.ID = id;
            this.Name = name;
            this.SAT = sat;
            this.GPA = gpa;
    
        }

        public void Print() {
            Console.WriteLine($"{this.ID}. {this.Name} has an SAT score of {this.SAT} and a GPA of {this.GPA}.");
        }

    }


}
