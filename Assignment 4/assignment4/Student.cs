using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
  class Student
  {
    public int Id { set; get; }
    public string Name { set; get; }
    public string StudentId { set; get; }
    public int CoursesTaken { set; get; }

    public Student()
    {
    }

    public Student(int Id, string Name, string StudentId)
    {
      this.Id = Id;
      this.Name = Name;
      this.StudentId = StudentId;
    }

    public void increaseCoursesTaken()
    {
      CoursesTaken++;
    }

    public void OutputStudentDetails()
    {
      Console.WriteLine("{0}(Student Id: {1} has taken {2} course(s)", Name, StudentId, CoursesTaken);
    }
  }
}
