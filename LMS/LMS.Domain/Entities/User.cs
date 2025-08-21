
namespace LMS.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        // Foreign Key
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        // Navigation
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Course> Courses { get; set; } = new List<Course>(); // Teacher's courses
        public ICollection<Log> Logs { get; set; } = new List<Log>();
    }
}
