using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class UserExperience
    {
        public int Id { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Position { get; set; }

        public string CompanyName { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
    }
}
