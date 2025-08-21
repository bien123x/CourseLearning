using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public string? VideoUrl { get; set; }
        public string? MaterialUrl { get; set; }
        public int OrderIndex { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
