using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models
{
    public class LoanRequest
    {
        public int Id { get; set; }
        public string Amount { get; set; }

        public string purpose { get; set; }

      
        public DateTime RequestDate { get; set; }

       
        public string ApprovedBy { get; set; }
        public string LoanStatus { get; set; }

       
        //Navigation Property
        public int LoanTypeId { get; set; }
        public LoanType LoanType { get; set; }


        //Navigation Property
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }


    }
}
