using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        List<T> LoadDataForRestAPI<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        
        Task<List<T>> GetData<T, U>(string sql, U parameters);

        void SaveDataForRestAPI<T>(string sql, T parameters);
    }
}