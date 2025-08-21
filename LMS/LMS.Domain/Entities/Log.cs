using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Log
    {
        public int LogId { get; set; }
        public string Action { get; set; } = null!;
        public string? Details { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
