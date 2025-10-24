using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISubscription
    {
        Task<List<SubscriptionModel>> GetSubscription(SubscriptionModel subscriptionPlan);
        Task InsertSubscription(SubscriptionModel subscription);
        Task UpdateSubscription(SubscriptionModel subscription);
        //Task DeleteSubscription(SubscriptionModel subscription);
        Task CancelSubscription(SubscriptionModel subscription);
        List<UserSubscriptionModel> GetCurrentUserSubscription(UserSubscriptionModel userSubscriptionPlan);
    }
}