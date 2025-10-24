using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IWebsite
    {
        List<WebsiteModel> GetWebsiteDetails(WebsiteModel website);
    }
}