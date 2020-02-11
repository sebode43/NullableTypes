using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    public class Major {
        public int ID { get; set; }
        public int MinSAT { get; set; }
        public string Description { get; set; }

        public Major(int id, int minSAT, string description) {
            this.ID = id;
            this.MinSAT = minSAT;
            this.Description = description;
        }

        public void Print() {
            Console.WriteLine($"{this.ID}. is for the major {this.Description}. Anyone with a SAT score equal to or greater than {this.MinSAT} is eligible to join {this.Description}.");
        }


    }
}
