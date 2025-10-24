using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class UserSubscriptionModel
    {
        public string UserName { get; set; }
        public string AltEmailid { get; set; }
        public Int16 StealthMode { get; set; }
        public string PlanId { get; set; }        
        public string LicenseId { get; set; }
        public string Status { get; set; }
        public string PlanName { get; set; }
        public Int16 Frequency { get; set; }
        public string emailid { get; set; }
        public string emailkey { get; set; }
    }
}
