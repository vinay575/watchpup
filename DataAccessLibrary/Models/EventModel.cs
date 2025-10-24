using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class EventModel
    {
        public EventModel() { }
        public string LicenseId { get; set; }
        public string MachineName { get; set; }
        public string UserName { get; set; }
        public DateTime UpdateDateTime { get; set; }        
    }
}
