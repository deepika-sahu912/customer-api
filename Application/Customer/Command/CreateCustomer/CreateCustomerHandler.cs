using System;
using Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Models;
using Serilog;


namespace Application.Customer.Command
{
    public class CreateCustomerHandler : ControllerBase, IRequestHandler<CreateCustomerReqDto, IActionResult>
    {
        private readonly IBaseRepository<Customers> _baseRepository;
        private readonly ILogger _logger;
        public CreateCustomerHandler(IBaseRepository<Customers> baseRepository, ILogger logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;

        }

        public async Task<IActionResult> Handle(CreateCustomerReqDto request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                _logger.Information("Process to Create Customer has started at {0}", DateTime.Now);
                var result = await _baseRepository.AddAsync(request.customer);
                return Ok(result);
                
            }
            else
            {
                _logger.Fatal("Process to Create Customer has failed due to Invalid request {0}", request);
                return BadRequest("Invalid Request");
            }

        }
    }
}

