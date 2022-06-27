using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Dtos
{
    public class PaymentDetailDto
    {
        public int PaymentDetailId { get; set; }
        [Required]
        public string CardOwnerName { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
        [Required]
        public string SecurityNumber { get; set; }
    }
}
