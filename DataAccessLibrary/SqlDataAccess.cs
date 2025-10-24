using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";
        public string ConnectionString = string.Empty;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
            if (_config?.GetSection("Environment")?.Value == "Development")
            {
                ConnectionString = _config?.GetSection("Development")?["ConnectionString"];
            }
            else if (_config?.GetSection("Environment").Value == "Production")
            {
                ConnectionString = _config?.GetSection("Production")?["ConnectionString"];
            }
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionStringName);
            
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }

            //try
            //{
            //    using (IDbConnection connection = new SqlConnection(connectionString))
            //    {
            //        var data = await connection.QueryAsync<T>(sql, parameters);

            //        return data.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{ }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionStringName);

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionString))
                {
                    await connection.ExecuteAsync(sql, parameters);
                }
            }
            catch (Exception ex)
            { }
        }

        public async Task<List<T>> GetData<T, U>(string sql, U parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionStringName);
            //object result = null;
            System.Collections.Generic.List<T> result = null;

            //using (IDbConnection connection = new SqlConnection(ConnectionString))
            //{
            //    var data = await connection.QueryAsync<T>(sql, parameters);

            //    return data.ToList();
            //}

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionString))
                {
                    var data = await connection.QueryAsync<T>(sql, parameters);

                    result = data.ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<T> LoadDataForRestAPI<T, U>(string sql, U parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var data =  connection.Query<T>(sql, parameters);

                return data.ToList();
            }

            //try
            //{
            //    using (IDbConnection connection = new SqlConnection(connectionString))
            //    {
            //        var data = await connection.QueryAsync<T>(sql, parameters);

            //        return data.ToList();
            //    }
            //}
            //catch (Exception ex)
            //{ }
        }

        void ISqlDataAccess.SaveDataForRestAPI<T>(string sql, T parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionStringName);

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionString))
                {
                     connection.Execute(sql, parameters);
                }
            }
            catch (Exception ex)
            { }
        }

        //void ISqlDataAccess.SaveDataForRestAPI<T>(string sql, T parameters)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
