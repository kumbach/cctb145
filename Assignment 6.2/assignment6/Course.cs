using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
  class Course
  {
    private int id;
    public string CourseKey { get; set; }
    public string CourseName;
    public List<Student> Students = new List<Student>();

    public int TotalStudents
    {
      get
      {
        return Students.Count();
      }
    }


    public Course()
    {
    }

    public Course(int id, string courseKey, string courseName)
    {
      this.id = id;
      this.CourseKey = courseKey;
      this.CourseName = courseName;
    }

    public void AddStudent(Student student)
    {
      Students.Add(student);
    }

  }
}
