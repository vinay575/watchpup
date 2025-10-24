using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IUser
    {
        Task<List<UserModel>> GetUsers();
        Task<List<UserModel>> GetUser(UserModel user);
        Task InsertUser(UserModel user);
        Task<List<UserModel>> AuthenticateUser(UserModel user);
        Task<List<UserModel>> SearchUsers(SearchModel search);
        Task UpdateUser(UserModel user);
        Task<List<UserModel>> CheckEmailVerificationId(UserModel user);
        Task UpdateVerifiedFlag(UserModel user);
        Task UpdateVerificationId(UserModel user);
        Task<List<UserModel>> CheckEmailId(UserModel user);
        Task UpdateForgotPasswordId(UserModel user);
        Task<List<UserModel>> CheckForgotPasswordId(UserModel user);
        Task UpdatePassword(UserModel user);
    }
}