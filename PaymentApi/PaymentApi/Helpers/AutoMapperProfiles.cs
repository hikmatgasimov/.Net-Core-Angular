using AutoMapper;
using PaymentApi.Dtos;
using PaymentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PaymentDetailDto, PaymentDetail>();
        }
    }
}
