using System;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Customer.Command
{
	public class DeleteCustomerReqDto : IRequest<IActionResult>
	{
        public int id { get; set; }

    }
}

