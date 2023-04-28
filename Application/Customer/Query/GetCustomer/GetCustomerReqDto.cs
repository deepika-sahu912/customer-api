using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Customer.Query
{
	public class GetCustomerReqDto : IRequest<IActionResult>
    {
		public GetCustomerReqDto()
		{
		}
	}
}

