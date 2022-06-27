using PaymentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Repositories.Impl
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;

        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }

        public PaymentDetail Add(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Add(paymentDetail);
            _context.SaveChanges();
            return paymentDetail;
        }

        public void Delete(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Remove(paymentDetail);
            _context.SaveChanges();
        }

        public PaymentDetail GetDetailById(int id)
        {
            return _context.PaymentDetails.Find(id);
        }

        public List<PaymentDetail> GetList()
        {
            return _context.PaymentDetails.ToList();
        }

        public PaymentDetail Update(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Update(paymentDetail);
            _context.SaveChanges();
            return paymentDetail;
        }
    }
}
