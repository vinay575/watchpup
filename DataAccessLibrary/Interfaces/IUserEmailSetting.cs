using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IUserEmailSetting
    {
        Task InsertUserEmailSetting(UserEmailSettingModel model);

        Task<List<UserEmailSettingModel>> GetUserEmailSetting(UserEmailSettingModel model);
    }
}