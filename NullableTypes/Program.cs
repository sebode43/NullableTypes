using System;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {

            var majors = new Major[] {
            new Major(100, 800, "General Business"),
            new Major(200, 1000, "Industrial Design"),
            new Major(300, 1200, "Computer Engineering"),
            new Major(400, 900, "General Education"),
            };

            foreach (var major in majors) {
                major.Print();
            }

            Console.WriteLine();

            var students = new Students[] {
            new Students(1, "Kelly Hudson", null, "3.75", majors[1]),
            new Students(2, "John Shelton", 1200, "3.9", majors[2]),
            new Students(3, "Blake Legend", 900, "3.5", majors[3]),
            new Students(4, "Gwen Clarkson", 1000, "3.68", null),
            };

            foreach (var student in students) {
                 student.Print();
            }
            
        }
    }
}
