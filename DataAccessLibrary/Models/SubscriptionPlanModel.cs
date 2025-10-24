using System;

namespace DataAccessLibrary.Models
{
    public class SubscriptionPlanModel
    {   
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string PlanId { get; set; }
        public string PlanName { get; set; }
        public string PlanDescription { get; set; }
        public Int32 Price { get; set; }
        public string BillingCycle { get; set; }
        public string TrialPeriod { get; set; }        
        public Int32 Env { get; set; }
    }
}
