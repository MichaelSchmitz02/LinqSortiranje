


using System;
using System.Linq;

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        var filteredStudents = studentArray
            .Where(s => s.Age > 18 && s.Age < 26)
            .OrderByDescending(s => s.Age);

        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"ID: {student.StudentID}, Ime: {student.StudentName}, Godine: {student.Age}");
        }
    }
}