using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PaymentModel
    {
        public string userId { get; set; }
        public string planType { get; set; }
        public string startDate { get; set; }
        public string EndDate { get; set; }
        public string LicenseId { get; set; }
        public string status { get; set; }
    }

    public enum PlanType
    { 
        Free,
        PlanA,
        PlanB
    }
}
