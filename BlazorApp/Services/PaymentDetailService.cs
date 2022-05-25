using BlazorApp.Models;
using BlazorApp.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        #region Property
        private IPaymentDetailRepos<PaymentDetail> paymentDetailRepos;
        private PaymentDetailContext paymentDetailContext;
        #endregion

        #region Constructor
        public PaymentDetailService(IPaymentDetailRepos<PaymentDetail> _repository, PaymentDetailContext _appDbContext)
        {
            paymentDetailRepos = _repository;
            paymentDetailContext = _appDbContext;
        }
        #endregion

        public List<PaymentDetail> GetPaymentsDetail() => paymentDetailRepos.GetAll();

        public PaymentDetail GetPaymentDetailbyId(int id) => paymentDetailContext.PaymentDetails.FirstOrDefault(c => c.PaymentDetailId.Equals(id));

        public void InsertPaymentDetail(PaymentDetail paymentDetail)
        {
            if (paymentDetail.PaymentDetailId is 0) paymentDetailRepos.Insert(paymentDetail);
            else paymentDetailRepos.Update(paymentDetail);
        }

        public void DeletePaymentDetail(int id)
        {
            PaymentDetail paymentDetail = paymentDetailContext.PaymentDetails.FirstOrDefault(c => c.PaymentDetailId.Equals(id));
            paymentDetailRepos.Remove(paymentDetail);
            paymentDetailRepos.SaveChanges();
        }
    }
}
