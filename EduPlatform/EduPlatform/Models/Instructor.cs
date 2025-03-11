using System.ComponentModel.DataAnnotations;

namespace EduPlatform.Models
{
    public class Instructor:BaseModel<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public List<Course> Courses { get; set; }
    }

}
