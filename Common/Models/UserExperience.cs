using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class UserExperience
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Position { get; set; }
        public string? CompanyName { get; set; }

        public virtual User? User { get; set; }
    }
}
