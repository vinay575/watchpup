using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISubscriptionPlan
    {
        Task<List<SubscriptionPlanModel>> GetSubscriptionPlans(SubscriptionPlanModel subscriptionPlan);
    }
}