using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUser
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetUsers()
        {
            string sql = "select * from dbo.Users";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task<List<UserModel>> GetUser(UserModel userModel)
        {
            string sql = "select * from dbo.Users where userid = @userid";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task InsertUser(UserModel person)
        {
            string sql = @"insert into dbo.Users (username, password, firstname, lastname, agreetermsconditions, verificationid, verificationidcreatedat, verificationidexpiresat, createdatetime, updatedatetime)
                           values (@username, @password, @firstname, @lastname, @agreetermsconditions, @verificationid, @verificationidcreatedat, @verificationidexpiresat, @createdatetime, @updatedatetime);";

            return _db.SaveData(sql, person);
        }

        public Task<List<UserModel>> AuthenticateUser(UserModel userModel)
        {
            string sql = @"select * from dbo.Users where username = @username and password = @password;";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task<List<UserModel>> SearchUsers(SearchModel search)
        {
            string sql = @"select * from dbo.Users;";

            return _db.GetData<UserModel, dynamic>(sql, search);
        }

        public Task UpdateUser(UserModel userModel)
        {
            string sql = @"update dbo.Users set firstname = @firstname, lastname = @lastname, password = @password, country = @country, altemailid = @altemailid, stealthmode = @stealthmode, @updatedatetime = updatedatetime where userid = @userid;";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task<List<UserModel>> CheckEmailVerificationId(UserModel userModel)
        {
            string sql = @"select * from dbo.Users where verificationid = @verificationid;";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task UpdateVerifiedFlag(UserModel userModel)
        {
            string sql = @"update dbo.Users set verified = @verified, updatedatetime = @updatedatetime where verificationid = @verificationid;";
            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task UpdateVerificationId(UserModel userModel)
        {
            string sql = @"update dbo.Users set verificationid = @verificationid, updatedatetime = @updatedatetime where userid = @userid;";
            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task<List<UserModel>> CheckEmailId(UserModel userModel)
        {
            string sql = @"select * from dbo.Users where username = @username;";
            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task UpdateForgotPasswordId(UserModel userModel)
        {
            string sql = @"update dbo.Users set forgotpasswordid = @forgotpasswordid, forgotpasswordcreatedat = @forgotpasswordIdcreatedat, forgotpasswordexpiresat = @forgotpasswordidexpiresat, updatedatetime = @updatedatetime where username = @username;";
            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }

        public Task<List<UserModel>> CheckForgotPasswordId(UserModel userModel)
        {
            string sql = @"select * from dbo.Users where forgotpasswordid = @forgotpasswordid;";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }
        public Task UpdatePassword(UserModel userModel)
        {
            string sql = @"update dbo.Users set password = @password, @updatedatetime = updatedatetime where userid = @userid;";

            return _db.GetData<UserModel, dynamic>(sql, userModel);
        }
    }
}
