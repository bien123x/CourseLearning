using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; } = "Unknown"; // e.g. CreditCard, Paypal
        public string Status { get; set; } = "Pending"; // Pending, Completed, Failed

        // Foreign Keys
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
