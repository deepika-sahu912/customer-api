using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Models;

namespace Application.Customer.Command
{
	public class CreateCustomerReqDto : IRequest<IActionResult>
    {
        public Customers customer { get; set; } = new Customers();
    }
}

