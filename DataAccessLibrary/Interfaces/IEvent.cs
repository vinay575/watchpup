using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IEvent
    {
       void InsertEvent(EventModel eventModel);
    }
}