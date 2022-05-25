using BlazorApp.Models;
using System.Collections.Generic;

namespace BlazorApp.Services
{
    public interface IPaymentDetailService
    {
        List<PaymentDetail> GetPaymentsDetail();
        PaymentDetail GetPaymentDetailbyId(int id);
        void InsertPaymentDetail(PaymentDetail payment);
        void DeletePaymentDetail(int id);
    }
}
