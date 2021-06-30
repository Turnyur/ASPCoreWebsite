using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set;}
        public string BVN { get; set; }
        public string NIN { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<LoanRequest> LoanRequests { get; set; }
    }
}
