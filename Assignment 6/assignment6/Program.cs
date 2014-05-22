using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
  class Program
  {
    static void Main(string[] args)
    {
      Course course = new Course(1, "C# Fundamentals");
      course.AddStudent(new Student(1, "John", 85, true));
      course.AddStudent(new Student(2, "Kerry", 65, true));
      course.AddStudent(new Student(3, "Luke", 45, false));
      course.AddStudent(new Student(4, "Barb", 90, true));
      course.AddStudent(new Student(5, "Peter", 100, true));

      Console.WriteLine("Students in the {0} course:", course.CourseName);
      foreach (Student student in course.Students)
      {
        Console.WriteLine("{0} finished with {1}% - Status : {2}", student.Name, student.Mark, student.PaidFees);
      }
      Console.WriteLine("{0} Total Students", course.TotalStudents);
    }
  }
}
