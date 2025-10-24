using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IPaymentData
    {
        Task<List<PaymentModel>> GetUserPaymentPlan();
        Task InsertPayment(PaymentModel user);
        Task UpdatePayment(PaymentModel user);
    }
}