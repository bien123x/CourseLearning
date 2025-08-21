namespace LMS.Domain.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
        public int Progress { get; set; } = 0; // %

        // Foreign Keys
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}