using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseAndORMConcepts_Lab3.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Required]

        [DisplayName("Course Title")]
        [MaxLength(100)]
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();
    }
}
