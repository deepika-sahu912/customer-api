using System;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application;
using Application.Customer.Command;
using Application.Customer.Query;
using Application.Customer.Command.UpdateCustomer;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/customer")]
	public class CustomerController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CustomerController(IMediator mediator)
		{
			_mediator = mediator;
        }

		[HttpPost]
		public async Task<IActionResult> CreateCustomer(CreateCustomerReqDto createCustomerRequest)
		{

			var result = await _mediator.Send(createCustomerRequest);
            return Ok(result);
		}

        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            GetCustomerReqDto getCustomerReqDto = new GetCustomerReqDto();
            var result = await _mediator.Send(getCustomerReqDto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerReqDto getCustomerReqDto)
        {
            var result = await _mediator.Send(getCustomerReqDto);
            return Ok(result);
        }

        [HttpDelete("id")]
		public async Task<IActionResult> DeleteCustomer(DeleteCustomerReqDto deleteCustomerDto)
		{
            var result = await _mediator.Send(deleteCustomerDto);
            return Ok(result);
        }
	}
}

