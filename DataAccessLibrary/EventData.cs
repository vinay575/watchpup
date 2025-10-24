using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class EventData : IEvent
    {
        private readonly ISqlDataAccess _db;

        public EventData(ISqlDataAccess db)
        {
            _db = db;
        }

        public void InsertEvent(EventModel eventModel)
        {
            try
            {
                string sql = @"insert into dbo.EVENTS (licenseid, machinename, username, updatedatetime)
                           values (@licenseid, @machinename, @username, @updatedatetime);"
                ;

                //string sql = @"insert into dbo.EVENTS (licenseid, machinename, username)
                //           values (@licenseid, @machinename, @username);";

                //eturn _db.sql, eventModel);
                _db.SaveDataForRestAPI(sql, eventModel);
                
            }
            catch (Exception ex) 
            {
            }

            //return Task.CompletedTask;
        }

       
    }
}
