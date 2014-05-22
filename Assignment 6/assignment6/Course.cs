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

    public Course(int id, string courseName)
    {
      this.id = id;
      this.CourseName = courseName;
    }

    public void AddStudent(Student student)
    {
      Students.Add(student);
    }

  }
}
