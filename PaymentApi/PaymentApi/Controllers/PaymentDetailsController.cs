using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentApi.Dtos;
using PaymentApi.Entities;
using PaymentApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;

        public PaymentDetailsController(IPaymentService paymentService,IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Payment Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_paymentService.GetList());
        }

        /// <summary>
        /// getDetailById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("detail/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_paymentService.GetDetailById(id));
        }

        /// <summary>
        /// Add Payment Detail
        /// </summary>
        /// <param name="paymentDetailDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]PaymentDetailDto paymentDetailDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var paymentDetail = _mapper.Map<PaymentDetail>(paymentDetailDto);

            var pd = _paymentService.Add(paymentDetail);

            return Created("Added ", pd);

        }

        /// <summary>
        /// Update Payment Detail
        /// </summary>
        /// <param name="paymentDetailDto"></param>
        /// <returns></returns>
        [HttpPut()]
        public IActionResult Update([FromBody]PaymentDetailDto paymentDetailDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var paymentDetail = _paymentService.GetDetailById(paymentDetailDto.PaymentDetailId);
            paymentDetail.CardOwnerName = paymentDetailDto.CardOwnerName;
            paymentDetail.CardNumber = paymentDetailDto.CardNumber;
            paymentDetail.ExpirationDate = paymentDetailDto.ExpirationDate;
            paymentDetail.SecurityNumber = paymentDetailDto.SecurityNumber;

            return Ok(_paymentService.Update(paymentDetail));
        }

        /// <summary>
        /// deleteById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete()]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var pd = _paymentService.GetDetailById(id);

            if (pd == null)
            {
                return NotFound();
            }
            _paymentService.Delete(pd);

            return Ok("Deleted");
        }
    }
}
