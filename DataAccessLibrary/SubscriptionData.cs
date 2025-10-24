using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SubscriptionData : ISubscription
    {
        private readonly ISqlDataAccess _db;

        public SubscriptionData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task InsertSubscription(SubscriptionModel subscription)
        {
            string sql = @"insert into dbo.SUBSCRIPTIONS (userid, planid, startdate, enddate, renewaldate, licenseid, status, ppsubscriptionid, ppbatoken, pptoken)
                           values (@userid, @planid, @startdate, @enddate, @renewaldate, @licenseid, @status, @ppsubscriptionid, @ppbatoken, @pptoken);"
            ;

            return _db.SaveData(sql, subscription); 
        }

        public Task UpdateSubscription(SubscriptionModel subscription)
        {
            string sql = @"select * from dbo.SUBSCRIPTIONS where username = @username and password = @password;";

            return _db.SaveData(sql, subscription);
        }

        public Task<List<SubscriptionModel>> GetSubscription(SubscriptionModel subscription)
        {
            string sql = "select s.subscriptionid,s.userid,s.planid,s.startdate,s.enddate,s.renewaldate,s.licenseid,s.status,s.ppsubscriptionid,s.ppbatoken,s.pptoken,sp.planname,sp.plandescription as features,sp.price ";
            sql += "from dbo.SUBSCRIPTIONS s inner join dbo.SUBSCRIPTIONPLANS sp on s.planid = sp.planid ";
            sql += "where status = 'Active' and userid = @userid";

            return _db.LoadData<SubscriptionModel, dynamic>(sql, subscription);
        }

        public Task CancelSubscription(SubscriptionModel subscription)
        {
            string sql = "update dbo.SUBSCRIPTIONS set status = 'Cancelled', renewaldate = '' where subscriptionid = @subscriptionid";

            return _db.LoadData<SubscriptionModel, dynamic>(sql, subscription);
        }

        public List<UserSubscriptionModel> GetCurrentUserSubscription(UserSubscriptionModel subscription)
        {
            string sql = "select u.username,u.altemailid,u.stealthmode,s.planid,s.licenseid,s.status,sp.planname,sp.frequency,ec.emailid,ec.emailkey ";
            sql += "from dbo.SUBSCRIPTIONS s inner join dbo.SUBSCRIPTIONPLANS sp on s.planid = sp.planid ";
            sql += "inner join dbo.USERS u on s.userid = u.userid ";
            sql += "inner join dbo.USEREMAILSETTINGS ues on ues.userid = u.userid ";
            sql += "inner join dbo.EMAILCONFIG ec on ec.emailconfigid = ues.emailconfigid ";
            sql += "where s.status = 'Active' and s.licenseid = @licenseid";

            return _db.LoadDataForRestAPI<UserSubscriptionModel, dynamic>(sql, subscription);
        }

    }
}
