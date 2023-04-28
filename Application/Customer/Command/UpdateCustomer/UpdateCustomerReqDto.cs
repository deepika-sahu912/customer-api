using System;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Customer.Command.UpdateCustomer
{
	public class UpdateCustomerReqDto : IRequest<IActionResult>
    {
        public Customers customer { get; set; } = new Customers();

    }
}

