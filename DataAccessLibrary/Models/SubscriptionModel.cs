using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class SubscriptionModel
    {
        public Int32 SubscriptionId { get; set; }
        public Int32 UserId { get; set; }
        public string PlanId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public string LicenseId { get; set; }
        public string Status { get; set; }
        public string PlanName { get; set; }
        public string Features { get; set; }
        public double Price { get; set; }
        public string PPSubscriptionId { get; set; }
        public string PPBAToken { get; set; }
        public string PPToken { get; set; }
        public string CancelLink { get; set; }
    }
}
