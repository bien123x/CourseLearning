using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsPublished { get; set; } = false;

        // Foreign Key (Teacher)
        public int TeacherId { get; set; }
        public User Teacher { get; set; } = null!;

        // Navigation
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
