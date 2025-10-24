using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserEmaiilSettingData : IUserEmailSetting
    {
        private readonly ISqlDataAccess _db;

        public UserEmaiilSettingData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task InsertUserEmailSetting(UserEmailSettingModel userEmailSettingModel)
        {
            string sql = @"insert into dbo.USEREMAILSETTINGS (userid, emailconfigid)
                           values (@userid, @emailconfigid);"
            ;

            return _db.SaveData(sql, userEmailSettingModel);
        }


        public Task<List<UserEmailSettingModel>> GetUserEmailSetting(UserEmailSettingModel subscription)
        {
            string sql = "select userid, emailconfigid from dbo.USEREMAILSETTINGS where userid = @userid";
            
            return _db.LoadData<UserEmailSettingModel, dynamic>(sql, subscription);
        }


    }
}
