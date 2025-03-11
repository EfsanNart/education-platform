using System.ComponentModel.DataAnnotations;

namespace EduPlatform.Models
{
    public class Student:BaseModel<int>
    {
      public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
