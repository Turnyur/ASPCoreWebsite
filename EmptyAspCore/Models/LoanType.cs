using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models
{
    public class LoanType
    {
        public int Id { get; set; }

       
        public string Name { get; set; }
        public string Interest { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
