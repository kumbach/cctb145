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
      List<Course> courses = new List<Course>();
      AddCoursesToList(courses);
      Dictionary<string, Course> courseDictionary = MakeCourseDictionary(courses);

      courseDictionary["CCTP152"].DisplaySummary();
      courseDictionary["CCTP150"].DisplaySummary();

    }

    private static void AddCoursesToList(List<Course> courses)
    {
      Course course = new Course(1, "CCTP150", "C# Fundamentals");
      course.AddStudent(new Student(1, "John", 85, true));
      course.AddStudent(new Student(2, "Kerry", 65, true));
      courses.Add(course);

      course = new Course(2, "CCTP152", "MVC Development Fundamentals");
      course.AddStudent(new Student(3, "Luke", 45, false));
      course.AddStudent(new Student(4, "Barb", 90, true));
      course.AddStudent(new Student(5, "Peter", 100, true));
      courses.Add(course);

      course = new Course(3, "CCTP154", "C# Advanced Programming");
      course.AddStudent(new Student(6, "Tom", 33, true));
      course.AddStudent(new Student(7, "Sue", 78, false));
      courses.Add(course);
    }

    private static Dictionary<string, Course> MakeCourseDictionary(List<Course> courses)
    {
      Dictionary<string, Course> courseDictionary = new Dictionary<string, Course>();
      foreach (Course course in courses)
      {
        courseDictionary.Add(course.CourseKey, course);
      }
      return courseDictionary;
    }
  }
}
