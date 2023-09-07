using Microsoft.Build.Framework;
using System.ComponentModel;

namespace AdvancedDatabaseAndORMConcepts_Lab3.Models
{
    public class Student
    {
        [DisplayName("Student Number")]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;
    }
}
