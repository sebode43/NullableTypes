using System;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {

            var students = new Students[] {
            new Students(1, "Kelly Hudson", null, "3.75"),
            new Students(2, "John Shelton", 1200, "3.9"),
            new Students(3, "Blake Legend", 900, "3.5"),
            new Students(4, "Gwen Clarkson", 1000, "3.68"),
            };

            foreach (var student in students) {
                 student.Print();
            }
        }
    }
}
