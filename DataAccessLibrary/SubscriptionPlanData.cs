using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SubscriptionPlanData : ISubscriptionPlan
    {
        private readonly ISqlDataAccess _db;

        public SubscriptionPlanData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SubscriptionPlanModel>> GetSubscriptionPlans(SubscriptionPlanModel subscriptionPlanModel)
        {
            string sql = "select productid, productname, productdescription, planid, planname, plandescription, price, billingcycle, trialperiod, env ";
            sql += "from dbo.SUBSCRIPTIONPLANS ";
            sql += "where env = @env order by productid;";

            try
            {
                return _db.GetData<SubscriptionPlanModel, dynamic>(sql, subscriptionPlanModel);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
