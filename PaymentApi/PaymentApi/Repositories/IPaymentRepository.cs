using PaymentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Repositories
{
    public interface IPaymentRepository
    {
        List<PaymentDetail> GetList();
        PaymentDetail GetDetailById(int id);
        PaymentDetail Update(PaymentDetail paymentDetail);
        PaymentDetail Add(PaymentDetail paymentDetail);
        void Delete(PaymentDetail paymentDetail);
    }
}
