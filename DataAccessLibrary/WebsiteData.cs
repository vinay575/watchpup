using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class WebsiteData : IWebsite
    {
        private readonly ISqlDataAccess _db;

        public WebsiteData(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<WebsiteModel> GetWebsiteDetails(WebsiteModel website)
        {
            string sql = @"select * from dbo.WEBSITE";
                        
            return _db.LoadDataForRestAPI<WebsiteModel, dynamic>(sql, website);
        }
    }
}
