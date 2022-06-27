using PaymentApi.Entities;
using PaymentApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Services.Impl
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public PaymentDetail Add(PaymentDetail paymentDetail)
        {
            return _paymentRepository.Add(paymentDetail);
        }

        public void Delete(PaymentDetail paymentDetail)
        {
            _paymentRepository.Delete(paymentDetail);
        }

        public PaymentDetail GetDetailById(int id)
        {
            return _paymentRepository.GetDetailById(id);
        }

        public List<PaymentDetail> GetList()
        {
            return _paymentRepository.GetList();
        }

        public PaymentDetail Update(PaymentDetail paymentDetail)
        {
            return _paymentRepository.Update(paymentDetail);
        }
    }
}
