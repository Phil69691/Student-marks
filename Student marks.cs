using System;
using System.Collections.Generic;

class Student {
    public string Name { get; set; }
    public int Mark { get; set; }
    public string Grade { get; set; }
}

class Program {
    static void Main(string[] args) {
      List<Student> students = new List<Student>();

    
      
      
      
      
      
      
        while (true) {
            Console.WriteLine("Enter a student name or press enter to finish:");
            string name = Console.ReadLine();
            if (name == "") {
                break;
            }
            Console.WriteLine("Enter the student's mark:");
            int mark = int.Parse(Console.ReadLine());
            string grade;
            if (mark >= 70 && mark <= 100) {
                grade = "A";
            } else if (mark >= 60 && mark <= 69) {
                grade = "B";
            } else if (mark >= 50 && mark <= 59) {
                grade = "C";
            } else if (mark >= 40 && mark <= 49) {
                grade = "D";
            } else {
                grade = "F";
            }

           
            Student student = new Student {
                Name = name,
                Mark = mark,
                Grade = grade
            };
            students.Add(student);
        }

        int totalMarks = 0;
        int numStudents = students.Count;
        foreach (Student student in students) {
            totalMarks += student.Mark;
        }
        double averageMark = (double)totalMarks / numStudents;

        
                 Console.WriteLine("Name\tMark\tGrade");
        foreach (Student student in students) {
            Console.WriteLine("{0}\t{1}\t{2}", student.Name, student.Mark, student.Grade);
        }

        
          Console.WriteLine("Total number of students: {0}", numStudents);
        Console.WriteLine("Average mark: {0:F2}", averageMark);
    }
}
