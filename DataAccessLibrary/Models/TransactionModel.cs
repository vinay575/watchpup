using System;

namespace DataAccessLibrary.Models
{
    public class TransactionModel
    {
        public Int32 TransactionId { get; set; }
        public Int32 SubscriptionId { get; set; }
        public Int32 UserId { get; set; }
        public Int32 PlanId { get; set; }
        public DateTime TransactionDate { get; set; }
        public Double Amount { get; set; }
        public DateTime RenewalDate { get; set; }
        public string Status { get; set; }        
    }
}
